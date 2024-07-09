using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static Models;

public class scr_WeaponController : MonoBehaviour
{
    private scr_CharacterController characterController;

    [Header("References")]
    public Animator weaponAnimator;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    [Header("Settings")]
    public WeaponSettingsModel settings;
    bool isInitialized;
    Vector3 newWeaponRotation;
    Vector3 newWeaponRotationVelocity;
    Vector3 targetWeaponRotation;
    Vector3 targetWeaponRotationVelocity;
    Vector3 targetWeaponMovementRotation;
    Vector3 targetWeaponMovementRotationVelocity;
    Vector3 newWeaponMovementRotation;
    Vector3 newWeaponMovementRotationVelocity;
    private bool isGroundedTrigger;
    private float fallingDelay;

    [Header("Weapon Sway")]
    public Transform weaponSwayObj;
    public float swayAmountA = 1;
    public float swayAmountB = 2;
    public float swayScale = 600;
    public float swayLerpSpeed = 14;
    float swayTime;
    Vector3 swayPosition;

    [Header("Sights")]
    public Transform sightTarget;
    public float sightOffset;
    public float aimingInTime;
    private Vector3 weaponSwayPosition;
    private Vector3 weaponSwayPositionVelocity;
    public Canvas crossHairCanvas;
    [HideInInspector]
    public bool isAimingIn;
    [Header("Shooting")]
    public float rateOfFire;
    public List<WeaponFireType> allowedFireTypes;
    public WeaponFireType currentFireType;
    [HideInInspector]
    public bool isShooting;
    [SerializeField]
    public float range = 100f;
    private scr_recoil recoil;
    public void Start(){
        newWeaponRotation = transform.localRotation.eulerAngles;
        currentFireType = allowedFireTypes.First();
        recoil = characterController.cameraHolder.GetChild(0).GetComponent<scr_recoil>();
    }
    public void Initialize(scr_CharacterController CharacterController){
        characterController = CharacterController;
        isInitialized = true;
    }
    private void Update(){
        if (!isInitialized){
            return;
        }
        if(isAimingIn){
            crossHairCanvas.gameObject.SetActive(false);
        }else{
            crossHairCanvas.gameObject.SetActive(true);
        }
        CalculateWeaponRotation();
        SetWeaponAnimations();
        CalculateWeaponSway();
        CalculateAimingIn();
        CalculateShooting();
    }

    #region - Shooting -
    private void CalculateShooting(){
        if(isShooting){
            Shoot();
            if (currentFireType == WeaponFireType.SemiAuto){
                isShooting = false;
            }
        }
    }
    private void Shoot(){
        var bullet = Instantiate(bulletPrefab,bulletSpawn);
        recoil.RecoilFire();
        RaycastHit hit;
        if (Physics.Raycast(characterController.camera.transform.position,characterController.camera.transform.forward, out hit, range)){
            var zombieHealth = hit.collider.GetComponent<scr_ZombieHealth>();
            if (zombieHealth){
                zombieHealth.TakeDamage(10);
            }
        }
}
    #endregion
    
    private void CalculateAimingIn(){
        var targetPosition = transform.position;
        if (isAimingIn){
            targetPosition = characterController.camera.transform.position + (weaponSwayObj.transform.position - sightTarget.position) + (characterController.camera.transform.forward * sightOffset);
        }
        weaponSwayPosition = weaponSwayObj.transform.position;
        weaponSwayPosition = Vector3.SmoothDamp(weaponSwayPosition,targetPosition,ref weaponSwayPositionVelocity,aimingInTime);
        weaponSwayObj.transform.position = weaponSwayPosition + swayPosition;
    }
    public void TriggerJump(){
        isGroundedTrigger = false;
        weaponAnimator.SetTrigger("Jump");
    }
    private void CalculateWeaponRotation(){
        targetWeaponRotation.y += (isAimingIn? settings.swayAmount / 3: settings.swayAmount) * (settings.swayXInverted ? -characterController.input_View.x : characterController.input_View.x) * Time.deltaTime;
        targetWeaponRotation.x += (isAimingIn? settings.swayAmount / 3: settings.swayAmount) * (settings.swayYInverted ? characterController.input_View.y : -characterController.input_View.y) * Time.deltaTime;

        targetWeaponRotation.x = Mathf.Clamp(targetWeaponRotation.x,-settings.swayClampX, settings.swayClampX);
        targetWeaponRotation.y = Mathf.Clamp(targetWeaponRotation.y, -settings.swayClampY,settings.swayClampY);
        targetWeaponRotation.z = isAimingIn ? 0: targetWeaponRotation.y;

        targetWeaponRotation = Vector3.SmoothDamp(targetWeaponRotation, Vector3.zero, ref targetWeaponRotationVelocity, settings.swayResetSmoothing);
        newWeaponRotation = Vector3.SmoothDamp(newWeaponRotation, targetWeaponRotation, ref newWeaponRotationVelocity, settings.swaySmoothing);

        targetWeaponMovementRotation.z =(isAimingIn?  settings.movemetSwayX /3 :  settings.movemetSwayX) * (settings.movementSwayXInverted ? -characterController.input_Movement.x : characterController.input_Movement.x);
        targetWeaponMovementRotation.x = (isAimingIn? settings.movemetSwayY/3 :  settings.movemetSwayY) * (settings.movementSwayYInverted ? -characterController.input_Movement.y : characterController.input_Movement.y);

        targetWeaponMovementRotation = Vector3.SmoothDamp(targetWeaponMovementRotation, Vector3.zero, ref targetWeaponMovementRotationVelocity, settings.movementSwaySmoothing);
        newWeaponMovementRotation = Vector3.SmoothDamp(newWeaponMovementRotation, targetWeaponMovementRotation, ref newWeaponMovementRotationVelocity, settings.movementSwaySmoothing);

        transform.localRotation = Quaternion.Euler(newWeaponRotation + newWeaponMovementRotation);
    }
    private void SetWeaponAnimations(){
        if(isGroundedTrigger){
            fallingDelay = 0;
        }
        else{
            fallingDelay += Time.deltaTime;
        }
        if(characterController.isGrounded && !isGroundedTrigger && fallingDelay > 0.1f){
            weaponAnimator.SetTrigger("Land");
            isGroundedTrigger = true;
        }
        if (!characterController.isGrounded && isGroundedTrigger){
            weaponAnimator.SetTrigger("Falling");
            isGroundedTrigger = false;
        }
        weaponAnimator.SetBool("isSprinting",characterController.isSprinting);
        weaponAnimator.SetFloat("weaponAnimationSpeed",characterController.weaponAnimationSpeed);
    }
    private void CalculateWeaponSway(){
        var targetPosition = LissajousCurve(swayTime,swayAmountA,swayAmountB) / (isAimingIn? swayScale * 3: swayScale);

        swayPosition = Vector3.Lerp(swayPosition,targetPosition,Time.smoothDeltaTime * swayLerpSpeed);
        swayTime += Time.deltaTime;

        if(swayTime > 6.3f){
            swayTime = 0;
        }
    }
    private Vector3 LissajousCurve(float Time,float A, float B){
        return new Vector3(Mathf.Sin(Time),A * Mathf.Sin(B* Time + Mathf.PI));
    }
}
