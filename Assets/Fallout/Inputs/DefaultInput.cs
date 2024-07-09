//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Fallout/Inputs/DefaultInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @DefaultInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @DefaultInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultInput"",
    ""maps"": [
        {
            ""name"": ""Character"",
            ""id"": ""05f85647-b4bd-4dcb-baf1-752354df5760"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""697c96c4-31d2-4918-9f45-1e8ee6eb71d7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""View"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c05f7e0a-8dfb-4a7f-a42a-c27e87edbaac"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""1463564e-8035-4965-b89a-12af3dd18329"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""ecd12209-eb48-4cd5-bd9a-73bec4310f68"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Prone"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2c3d1450-5ee1-4500-bf1a-ab09cdbe2e11"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""2b5050df-f3a9-4942-844f-478f92b3d027"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SprintReleased"",
                    ""type"": ""Button"",
                    ""id"": ""3c071d5f-7b15-4054-98d3-7c62a2cea82b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeanLeftPressed"",
                    ""type"": ""Button"",
                    ""id"": ""c277c3a3-9e94-4586-953c-a74d992d79f6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeanRightPressed"",
                    ""type"": ""Button"",
                    ""id"": ""d51d726f-509a-4022-896f-bf08b3aa9ffc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeanLeftReleased"",
                    ""type"": ""Button"",
                    ""id"": ""f9472d5e-7402-4ebf-9bfc-3baebce283f6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeanRightReleased"",
                    ""type"": ""Button"",
                    ""id"": ""3f60d80e-0249-43c9-bf8a-d8f87096aee7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e6f5c5fd-125b-443a-b13e-1912f8b7e634"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""5c228c78-0dba-4b4f-9f5c-9b7ad9d32441"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6efe3b7e-515b-4147-a190-ded5391077ed"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2202fc91-a09f-4605-8614-2190e86cfc96"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2ffffba4-67f6-4e06-a38f-b27ea67a1d0c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ea44ca50-64b1-4660-9b99-e17f0fca6f37"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a30e58f7-d24c-416e-9c73-ef87c30780f6"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e3091f4-bd1b-49bf-95c4-c6f3e3486395"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""35b7fbc0-7730-4302-99db-b5e7a03924bd"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Prone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d7fcf17-323e-4ee6-83aa-34a310b4d9a1"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Prone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3527d362-faa6-4ca5-ad76-7255500cc6e0"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58af177d-5ca1-462b-b38f-795552b58d10"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SprintReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""403922f0-2d48-4a3a-87c9-0272b48a9503"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeanLeftPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80888f86-802e-4804-8ee5-b17c49e1989d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeanRightPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91aa1cc1-d188-400f-8dd5-ade4f856c548"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeanLeftReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aca2e39b-180a-4ec5-a993-bd84b86a251d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeanRightReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Weapon"",
            ""id"": ""f10a2a6e-b5d5-4043-b48d-e5251fc35205"",
            ""actions"": [
                {
                    ""name"": ""Fire2Pressed"",
                    ""type"": ""Button"",
                    ""id"": ""4bb8c38c-8632-4e4d-a17d-6d999c5e2461"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire2Released"",
                    ""type"": ""Button"",
                    ""id"": ""0168f35f-8ee7-4923-b0ea-6deebeab0bad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire1Pressed"",
                    ""type"": ""Button"",
                    ""id"": ""d2a8048c-5478-4bea-a64c-6ea1214400d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire1Released"",
                    ""type"": ""Button"",
                    ""id"": ""65c93b29-5338-400a-a75d-013f5d81daec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""83630ca4-7a12-4655-9759-a261cfb25dad"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire2Pressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""216efb15-8ed4-45e6-a77c-41561df3d8b3"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire2Released"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0fc92ca2-0de8-48fe-be48-af53e3046a36"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire1Pressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e320c85d-0e5a-447e-b2d1-2baf7c7c8a09"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire1Released"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Character
        m_Character = asset.FindActionMap("Character", throwIfNotFound: true);
        m_Character_Movement = m_Character.FindAction("Movement", throwIfNotFound: true);
        m_Character_View = m_Character.FindAction("View", throwIfNotFound: true);
        m_Character_Jump = m_Character.FindAction("Jump", throwIfNotFound: true);
        m_Character_Crouch = m_Character.FindAction("Crouch", throwIfNotFound: true);
        m_Character_Prone = m_Character.FindAction("Prone", throwIfNotFound: true);
        m_Character_Sprint = m_Character.FindAction("Sprint", throwIfNotFound: true);
        m_Character_SprintReleased = m_Character.FindAction("SprintReleased", throwIfNotFound: true);
        m_Character_LeanLeftPressed = m_Character.FindAction("LeanLeftPressed", throwIfNotFound: true);
        m_Character_LeanRightPressed = m_Character.FindAction("LeanRightPressed", throwIfNotFound: true);
        m_Character_LeanLeftReleased = m_Character.FindAction("LeanLeftReleased", throwIfNotFound: true);
        m_Character_LeanRightReleased = m_Character.FindAction("LeanRightReleased", throwIfNotFound: true);
        // Weapon
        m_Weapon = asset.FindActionMap("Weapon", throwIfNotFound: true);
        m_Weapon_Fire2Pressed = m_Weapon.FindAction("Fire2Pressed", throwIfNotFound: true);
        m_Weapon_Fire2Released = m_Weapon.FindAction("Fire2Released", throwIfNotFound: true);
        m_Weapon_Fire1Pressed = m_Weapon.FindAction("Fire1Pressed", throwIfNotFound: true);
        m_Weapon_Fire1Released = m_Weapon.FindAction("Fire1Released", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Character
    private readonly InputActionMap m_Character;
    private List<ICharacterActions> m_CharacterActionsCallbackInterfaces = new List<ICharacterActions>();
    private readonly InputAction m_Character_Movement;
    private readonly InputAction m_Character_View;
    private readonly InputAction m_Character_Jump;
    private readonly InputAction m_Character_Crouch;
    private readonly InputAction m_Character_Prone;
    private readonly InputAction m_Character_Sprint;
    private readonly InputAction m_Character_SprintReleased;
    private readonly InputAction m_Character_LeanLeftPressed;
    private readonly InputAction m_Character_LeanRightPressed;
    private readonly InputAction m_Character_LeanLeftReleased;
    private readonly InputAction m_Character_LeanRightReleased;
    public struct CharacterActions
    {
        private @DefaultInput m_Wrapper;
        public CharacterActions(@DefaultInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Character_Movement;
        public InputAction @View => m_Wrapper.m_Character_View;
        public InputAction @Jump => m_Wrapper.m_Character_Jump;
        public InputAction @Crouch => m_Wrapper.m_Character_Crouch;
        public InputAction @Prone => m_Wrapper.m_Character_Prone;
        public InputAction @Sprint => m_Wrapper.m_Character_Sprint;
        public InputAction @SprintReleased => m_Wrapper.m_Character_SprintReleased;
        public InputAction @LeanLeftPressed => m_Wrapper.m_Character_LeanLeftPressed;
        public InputAction @LeanRightPressed => m_Wrapper.m_Character_LeanRightPressed;
        public InputAction @LeanLeftReleased => m_Wrapper.m_Character_LeanLeftReleased;
        public InputAction @LeanRightReleased => m_Wrapper.m_Character_LeanRightReleased;
        public InputActionMap Get() { return m_Wrapper.m_Character; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
        public void AddCallbacks(ICharacterActions instance)
        {
            if (instance == null || m_Wrapper.m_CharacterActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CharacterActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @View.started += instance.OnView;
            @View.performed += instance.OnView;
            @View.canceled += instance.OnView;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Crouch.started += instance.OnCrouch;
            @Crouch.performed += instance.OnCrouch;
            @Crouch.canceled += instance.OnCrouch;
            @Prone.started += instance.OnProne;
            @Prone.performed += instance.OnProne;
            @Prone.canceled += instance.OnProne;
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
            @SprintReleased.started += instance.OnSprintReleased;
            @SprintReleased.performed += instance.OnSprintReleased;
            @SprintReleased.canceled += instance.OnSprintReleased;
            @LeanLeftPressed.started += instance.OnLeanLeftPressed;
            @LeanLeftPressed.performed += instance.OnLeanLeftPressed;
            @LeanLeftPressed.canceled += instance.OnLeanLeftPressed;
            @LeanRightPressed.started += instance.OnLeanRightPressed;
            @LeanRightPressed.performed += instance.OnLeanRightPressed;
            @LeanRightPressed.canceled += instance.OnLeanRightPressed;
            @LeanLeftReleased.started += instance.OnLeanLeftReleased;
            @LeanLeftReleased.performed += instance.OnLeanLeftReleased;
            @LeanLeftReleased.canceled += instance.OnLeanLeftReleased;
            @LeanRightReleased.started += instance.OnLeanRightReleased;
            @LeanRightReleased.performed += instance.OnLeanRightReleased;
            @LeanRightReleased.canceled += instance.OnLeanRightReleased;
        }

        private void UnregisterCallbacks(ICharacterActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @View.started -= instance.OnView;
            @View.performed -= instance.OnView;
            @View.canceled -= instance.OnView;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Crouch.started -= instance.OnCrouch;
            @Crouch.performed -= instance.OnCrouch;
            @Crouch.canceled -= instance.OnCrouch;
            @Prone.started -= instance.OnProne;
            @Prone.performed -= instance.OnProne;
            @Prone.canceled -= instance.OnProne;
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
            @SprintReleased.started -= instance.OnSprintReleased;
            @SprintReleased.performed -= instance.OnSprintReleased;
            @SprintReleased.canceled -= instance.OnSprintReleased;
            @LeanLeftPressed.started -= instance.OnLeanLeftPressed;
            @LeanLeftPressed.performed -= instance.OnLeanLeftPressed;
            @LeanLeftPressed.canceled -= instance.OnLeanLeftPressed;
            @LeanRightPressed.started -= instance.OnLeanRightPressed;
            @LeanRightPressed.performed -= instance.OnLeanRightPressed;
            @LeanRightPressed.canceled -= instance.OnLeanRightPressed;
            @LeanLeftReleased.started -= instance.OnLeanLeftReleased;
            @LeanLeftReleased.performed -= instance.OnLeanLeftReleased;
            @LeanLeftReleased.canceled -= instance.OnLeanLeftReleased;
            @LeanRightReleased.started -= instance.OnLeanRightReleased;
            @LeanRightReleased.performed -= instance.OnLeanRightReleased;
            @LeanRightReleased.canceled -= instance.OnLeanRightReleased;
        }

        public void RemoveCallbacks(ICharacterActions instance)
        {
            if (m_Wrapper.m_CharacterActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICharacterActions instance)
        {
            foreach (var item in m_Wrapper.m_CharacterActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CharacterActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CharacterActions @Character => new CharacterActions(this);

    // Weapon
    private readonly InputActionMap m_Weapon;
    private List<IWeaponActions> m_WeaponActionsCallbackInterfaces = new List<IWeaponActions>();
    private readonly InputAction m_Weapon_Fire2Pressed;
    private readonly InputAction m_Weapon_Fire2Released;
    private readonly InputAction m_Weapon_Fire1Pressed;
    private readonly InputAction m_Weapon_Fire1Released;
    public struct WeaponActions
    {
        private @DefaultInput m_Wrapper;
        public WeaponActions(@DefaultInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fire2Pressed => m_Wrapper.m_Weapon_Fire2Pressed;
        public InputAction @Fire2Released => m_Wrapper.m_Weapon_Fire2Released;
        public InputAction @Fire1Pressed => m_Wrapper.m_Weapon_Fire1Pressed;
        public InputAction @Fire1Released => m_Wrapper.m_Weapon_Fire1Released;
        public InputActionMap Get() { return m_Wrapper.m_Weapon; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WeaponActions set) { return set.Get(); }
        public void AddCallbacks(IWeaponActions instance)
        {
            if (instance == null || m_Wrapper.m_WeaponActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_WeaponActionsCallbackInterfaces.Add(instance);
            @Fire2Pressed.started += instance.OnFire2Pressed;
            @Fire2Pressed.performed += instance.OnFire2Pressed;
            @Fire2Pressed.canceled += instance.OnFire2Pressed;
            @Fire2Released.started += instance.OnFire2Released;
            @Fire2Released.performed += instance.OnFire2Released;
            @Fire2Released.canceled += instance.OnFire2Released;
            @Fire1Pressed.started += instance.OnFire1Pressed;
            @Fire1Pressed.performed += instance.OnFire1Pressed;
            @Fire1Pressed.canceled += instance.OnFire1Pressed;
            @Fire1Released.started += instance.OnFire1Released;
            @Fire1Released.performed += instance.OnFire1Released;
            @Fire1Released.canceled += instance.OnFire1Released;
        }

        private void UnregisterCallbacks(IWeaponActions instance)
        {
            @Fire2Pressed.started -= instance.OnFire2Pressed;
            @Fire2Pressed.performed -= instance.OnFire2Pressed;
            @Fire2Pressed.canceled -= instance.OnFire2Pressed;
            @Fire2Released.started -= instance.OnFire2Released;
            @Fire2Released.performed -= instance.OnFire2Released;
            @Fire2Released.canceled -= instance.OnFire2Released;
            @Fire1Pressed.started -= instance.OnFire1Pressed;
            @Fire1Pressed.performed -= instance.OnFire1Pressed;
            @Fire1Pressed.canceled -= instance.OnFire1Pressed;
            @Fire1Released.started -= instance.OnFire1Released;
            @Fire1Released.performed -= instance.OnFire1Released;
            @Fire1Released.canceled -= instance.OnFire1Released;
        }

        public void RemoveCallbacks(IWeaponActions instance)
        {
            if (m_Wrapper.m_WeaponActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IWeaponActions instance)
        {
            foreach (var item in m_Wrapper.m_WeaponActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_WeaponActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public WeaponActions @Weapon => new WeaponActions(this);
    public interface ICharacterActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnView(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnProne(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnSprintReleased(InputAction.CallbackContext context);
        void OnLeanLeftPressed(InputAction.CallbackContext context);
        void OnLeanRightPressed(InputAction.CallbackContext context);
        void OnLeanLeftReleased(InputAction.CallbackContext context);
        void OnLeanRightReleased(InputAction.CallbackContext context);
    }
    public interface IWeaponActions
    {
        void OnFire2Pressed(InputAction.CallbackContext context);
        void OnFire2Released(InputAction.CallbackContext context);
        void OnFire1Pressed(InputAction.CallbackContext context);
        void OnFire1Released(InputAction.CallbackContext context);
    }
}
