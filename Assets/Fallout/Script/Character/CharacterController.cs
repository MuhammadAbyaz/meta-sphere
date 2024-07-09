using UnityEngine;
using static Models;

public class scr_CharacterController : MonoBehaviour
{
    private CharacterController characterController;
    private DefaultInput defaultInput;
    private Vector3 newCameraRotation;
    private Vector3 newCharacterRotation;
    [HideInInspector]
    public Vector2 input_Movement;
    [HideInInspector]
    public Vector2 input_View;

    [Header("References")]
    public Transform cameraHolder;
    public Transform camera;
    public Transform feetTransform;
    [Header("Settings")]
    public PlayerSettingsModel playerSettings;
    public float viewClampYMin = -70;
    public float viewClampYMax = 80;
    public LayerMask playerMask;
    public LayerMask groundMask;

    [Header("Gravity")]
    public float gravityAmount; 
    public float gravityMin;
    private float playerGravity;

    public Vector3 jumpingForce;
    private Vector3 jumpingForceVelocity;

    [Header("Stance")]
    public PlayerStance playerStance;
    public float playerStanceSmoothing;

    private Vector3 stanceCapsuleCenterVelocity;
    private float stanceCapsuleHeightVelocity;

    public CharacterStance playerStandStance;
    public CharacterStance playerCrouchStance;
    public CharacterStance playerProneStance;
    private float stanceCheckErrorMargin = 0.05f;
    private float cameraHeight;
    private float cameraHeightVelocity;
    [HideInInspector]
    public bool isSprinting;
    private Vector3 newMovementSpeed;
    private Vector3 newMovementSpeedVelocity;
    [Header("Weapon")]
    public scr_WeaponController currentWeapon;
    public float weaponAnimationSpeed;

    [HideInInspector]
    public bool isGrounded;
    [HideInInspector]
    public bool isFalling = true;
    [Header("Leaning")]
    public Transform leanPivot;
    private float currentLean;
    private float targetLean;
    public float leanAngle;
    public float leanSmoothing;
    private float leanVelocity;
    private bool isLeaningLeft;
    private bool isLeaningRight;
    [Header("Aiming in")]
    public bool isAimingIn;

    #region - Awake -
    private void Awake(){
        defaultInput  = new DefaultInput();
        defaultInput.Character.Movement.performed += e => input_Movement = e.ReadValue<Vector2>();
        defaultInput.Character.View.performed += e => input_View = e.ReadValue<Vector2>();
        defaultInput.Character.Jump.performed += e => Jump();

        defaultInput.Character.Crouch.performed += e => Crouch();
        defaultInput.Character.Prone.performed += e => Prone();
        defaultInput.Character.Sprint.performed += e => ToggleSprint();
        defaultInput.Character.SprintReleased.performed += e => StopSprint();
        defaultInput.Weapon.Fire2Pressed.performed += e => AimingInPressed();
        defaultInput.Weapon.Fire2Released.performed += e => AimingInReleased();
        defaultInput.Weapon.Fire1Pressed.performed += e => ShootingPressed();
        defaultInput.Weapon.Fire1Released.performed += e => ShootingReleased();
        defaultInput.Character.LeanLeftPressed.performed += e=> isLeaningLeft = true;
        defaultInput.Character.LeanLeftReleased.performed += e=> isLeaningLeft = false;
        defaultInput.Character.LeanRightPressed.performed += e=> isLeaningRight = true;
        defaultInput.Character.LeanRightReleased.performed += e=> isLeaningRight = false;

        defaultInput.Enable();

        newCameraRotation = cameraHolder.localRotation.eulerAngles;
        newCharacterRotation = transform.localRotation.eulerAngles;

        characterController = GetComponent<CharacterController>();

        cameraHeight = cameraHolder.localPosition.y;
        if(currentWeapon){
            currentWeapon.Initialize(this);
        }
    }
    #endregion
    #region - Update 
    private void Update(){
        SetIsFalling();
        SetIsGrounded();
        CalculateView();
        CalculateMovement();
        CalculateJump();
        CalculateStance();
        CalculateAimingIn();
        CalculateLeaning();
        StanceCheck(playerStandStance.stanceCollider.height);
    }
    #endregion
    #region - Shooting
    private void ShootingPressed(){
        if(!currentWeapon){
            return;
        }
        currentWeapon.isShooting = true;
    }
    private void ShootingReleased(){
        if(!currentWeapon){
            return;
        }
        currentWeapon.isShooting = false;
    }
    #endregion
    #region - Aiming In -
    private void AimingInPressed(){
        isAimingIn = true;
    }
    private void AimingInReleased(){

        isAimingIn = false;
    }

    private void CalculateAimingIn(){
        if(!currentWeapon){return;}
        currentWeapon.isAimingIn = isAimingIn;
    }
    #endregion
    #region - IsFalling / IsGrounded -
    private void SetIsGrounded(){
        isGrounded = Physics.CheckSphere(feetTransform.position,playerSettings.isGroundedRadius, groundMask);
    }    
    private void SetIsFalling(){
        if(!isGrounded && (characterController.velocity.magnitude >= playerSettings.isFallingSpeed)){
            isFalling = true;
        }else{
            isFalling = false;
        }
    }
    #endregion
    #region - View / Movement
    private void CalculateView(){
        newCharacterRotation.y += (isAimingIn? playerSettings.viewXSensitivity *playerSettings.aimingSensitivityEffector: playerSettings.viewXSensitivity) * (playerSettings.ViewXInverted ? -input_View.x : input_View.x)* Time.deltaTime;
        transform.localRotation = Quaternion.Euler(newCharacterRotation);

        newCameraRotation.x += (isAimingIn? playerSettings.viewYSensitivity * playerSettings.aimingSensitivityEffector :playerSettings.viewYSensitivity) * (playerSettings.ViewYInverted ? input_View.y : -input_View.y) * Time.deltaTime;
        newCameraRotation.x = Mathf.Clamp(newCameraRotation.x, viewClampYMin,viewClampYMax);
        cameraHolder.localRotation = Quaternion.Euler(newCameraRotation);
    }
    private void CalculateMovement(){

        if(input_Movement.y <= 0.2f){
            isSprinting = false;
        }
        var verticalSpeed = playerSettings.walkingForwardSpeed;
        var horizontalSpeed = playerSettings.walkingStrafeSpeed;

        if (isSprinting){
            verticalSpeed = playerSettings.runningForwardSpeed;
            horizontalSpeed = playerSettings.runningStrafeSpeed;
        }

        if (!isGrounded){
            playerSettings.speedEffector = playerSettings.fallingSpeedEffector;

        } else if(playerStance == PlayerStance.Crouch){
            playerSettings.speedEffector = playerSettings.crouchSpeedEffector;
        }
        else if(playerStance == PlayerStance.Prone){
            playerSettings.speedEffector = playerSettings.proneSpeedEffector;
        }        
        else if(isAimingIn){
            playerSettings.speedEffector = playerSettings.aimingSpeedEffector;
        }
        else{
            playerSettings.speedEffector = 1;
        }

        weaponAnimationSpeed = characterController.velocity.magnitude / (playerSettings.walkingForwardSpeed * playerSettings.speedEffector) ;

        if(weaponAnimationSpeed > 1){
            weaponAnimationSpeed = 1;
        }

        verticalSpeed *= playerSettings.speedEffector;
        horizontalSpeed *= playerSettings.speedEffector;

        newMovementSpeed = Vector3.SmoothDamp(newMovementSpeed, new Vector3(horizontalSpeed * input_Movement.x * Time.deltaTime,0, verticalSpeed * input_Movement.y * Time.deltaTime), ref newMovementSpeedVelocity, isGrounded ? playerSettings.movementSmoothing: playerSettings.fallingSmoothing);

        var movementSpeed = transform.TransformDirection(newMovementSpeed);
        if (playerGravity > gravityMin){
        playerGravity -= gravityAmount * Time.deltaTime;
        }
        if(playerGravity < -0.1f && isGrounded){
            playerGravity = -0.1f;
        }
        movementSpeed.y += playerGravity;
        movementSpeed += jumpingForce * Time.deltaTime;

        characterController.Move(movementSpeed);
    }
    #endregion   
    #region - Leaning -
    private void CalculateLeaning(){
        if(isLeaningLeft){
            targetLean = leanAngle;
        }
        else if (isLeaningRight){
            targetLean = -leanAngle;
        }
        else{
            targetLean = 0;
        }
        currentLean = Mathf.SmoothDamp(currentLean,targetLean,ref leanVelocity, leanSmoothing);
        leanPivot.localRotation = Quaternion.Euler(new Vector3(0,0,currentLean));
    }
    #endregion
    #region - Jumping -
    private void CalculateJump(){
        jumpingForce = Vector3.SmoothDamp(jumpingForce, Vector3.zero, ref jumpingForceVelocity, playerSettings.JumpingFalloff);
    }
    private void Jump(){
        if (!isGrounded || playerStance == PlayerStance.Prone){
            return;
        }
        if (playerStance == PlayerStance.Crouch && !StanceCheck(playerStandStance.stanceCollider.height)){
            playerStance = PlayerStance.Stand;
            return;
        }
        jumpingForce = Vector3.up * playerSettings.JumpingHeight;
        playerGravity = 0;
        currentWeapon.TriggerJump();
    }
    #endregion
    #region - Stance -
    private void CalculateStance(){
        var currentStance = playerStandStance;
        if(playerStance == PlayerStance.Crouch){
            currentStance = playerCrouchStance;
        } else if (playerStance == PlayerStance.Prone){
            currentStance = playerProneStance;
        }
        cameraHeight = Mathf.SmoothDamp(cameraHolder.localPosition.y, currentStance.cameraHeight, ref cameraHeightVelocity, playerStanceSmoothing);
        cameraHolder.localPosition = new Vector3(cameraHolder.localPosition.x,cameraHeight,cameraHolder.localPosition.z);

        characterController.height = Mathf.SmoothDamp(characterController.height, currentStance.stanceCollider.height, ref stanceCapsuleHeightVelocity, playerStanceSmoothing);
        characterController.center = Vector3.SmoothDamp(characterController.center, currentStance.stanceCollider.center, ref stanceCapsuleCenterVelocity, playerStanceSmoothing);
    }
    private bool StanceCheck(float stanceCheckHeight){
        var start = new Vector3(feetTransform.position.x, feetTransform.position.y + characterController.radius +  stanceCheckErrorMargin, feetTransform.position.z);
        var end = new Vector3(feetTransform.position.x, feetTransform.position.y - characterController.radius -  stanceCheckErrorMargin + stanceCheckHeight , feetTransform.position.z);

        return Physics.CheckCapsule(start,end,characterController.radius,playerMask);
    }
    private void Crouch(){
        if (playerStance == PlayerStance.Crouch){
            if (StanceCheck(playerStandStance.stanceCollider.height)){
                return;
            }
            playerStance = PlayerStance.Stand;
            return;
        }
        if (StanceCheck(playerCrouchStance.stanceCollider.height)){
                return;
            }
        playerStance = PlayerStance.Crouch;
    }
    private void Prone(){
        playerStance = PlayerStance.Prone;
    }
#endregion
    #region - Sprinting -
    private void ToggleSprint(){
        if(input_Movement.y <= 0.2f){
            isSprinting = false;
            return;
        }
        isSprinting = !isSprinting;
    }
    private void StopSprint(){
        if(playerSettings.sprintingHold){
            isSprinting = false;
        }
    }
    #endregion
    #region - Gizmos -
    private void OnDrawGizmos(){
        Gizmos.DrawWireSphere(feetTransform.position,playerSettings.isGroundedRadius);
    }
    #endregion
}
