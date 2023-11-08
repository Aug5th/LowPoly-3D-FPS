//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/_Script/Input/PlayerInput.inputactions
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

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""OnFoot"",
            ""id"": ""6ff99f5c-c640-400b-8a88-6b3f2f2a843a"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""cd4d6671-e93c-43d6-b55d-682c28b9393c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c6bf3060-2cce-431b-aaee-bfe9e9e48e90"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""c68dab94-4bc1-4b85-975b-823163fa5d7a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d0bbfa74-c3c2-4164-bafd-84445f14b1f8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""PassThrough"",
                    ""id"": ""29673dbb-d90d-40e6-8fac-aeaa9a04e23b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""b8db4635-cdff-4f85-8a16-fb908ec1d1b7"",
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
                    ""id"": ""e4be9eb9-4a34-4885-9258-b5bfe7de11ee"",
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
                    ""id"": ""278f6a4d-06ea-431c-8773-0c2c029c1316"",
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
                    ""id"": ""8e7e8164-5cac-41e0-bb86-aaf0161e5e69"",
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
                    ""id"": ""e8d053d9-f11c-498a-827b-04adb3fe109d"",
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
                    ""id"": ""8aa8261f-03e7-4c81-ad01-ef4d58e883c0"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1fc44b2c-b82a-4463-9b56-a253ebed3ed7"",
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
                    ""id"": ""ef52e18f-9bcd-4c14-924e-8940240ea4be"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6bfd43b0-4850-41da-87cd-b2e79bfe137f"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11310ec6-aba4-4413-8255-724195dffeab"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a65a9531-5d44-46d4-b9aa-694d23839e27"",
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
                    ""id"": ""36d6656f-d56b-4ca6-b672-fdf8503585ca"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""OnHand"",
            ""id"": ""0ecaa408-a438-433c-aa1b-44680f5c82e0"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0f342f20-d8d0-436b-bf53-6337b6b3c6c0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b3fd6a20-708f-4729-8c4a-c47d3f108fea"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""GetFirstWeapon"",
                    ""type"": ""Value"",
                    ""id"": ""aba1587c-b936-44e7-b140-da684191712b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""GetSecondWeapon"",
                    ""type"": ""Value"",
                    ""id"": ""f1ebbf7c-82c6-449e-9e30-0640511e716c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""GetThirdWeapon"",
                    ""type"": ""Value"",
                    ""id"": ""86014493-e3d5-44fa-87ac-f2a58b3b3ff7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""ecbcfb45-f8de-4d12-8f82-f518539c1e9c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SwitchWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""5c326d59-a49f-43a6-ae94-abfbeb459b22"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""DropWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""5622cc3f-ec7d-4629-8799-a258f3425dc2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""742bdcc6-3dd1-4b74-b912-a08dd6e597c0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d11624ef-8b3b-47e0-8376-9c0c4346e323"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""770793a6-63de-4e38-91b9-c773f23f4a39"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d10b4bd7-4b73-4fe0-b35d-fcdc22afbb94"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GetFirstWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75e075c9-9399-40b8-ae99-92d5bc1f0a1b"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GetSecondWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa60027d-71e3-46f9-9073-65904b476eb2"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GetThirdWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70e67ec2-6710-42c7-99ba-c2f3039a9c07"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a871cf5-f022-45ea-914d-a2cc6d844b7e"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca308a4e-ad81-4167-84c6-a0ffc10709f4"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5aba0d91-8754-40a7-8509-95984c2b5b87"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // OnFoot
        m_OnFoot = asset.FindActionMap("OnFoot", throwIfNotFound: true);
        m_OnFoot_Movement = m_OnFoot.FindAction("Movement", throwIfNotFound: true);
        m_OnFoot_Jump = m_OnFoot.FindAction("Jump", throwIfNotFound: true);
        m_OnFoot_Look = m_OnFoot.FindAction("Look", throwIfNotFound: true);
        m_OnFoot_Sprint = m_OnFoot.FindAction("Sprint", throwIfNotFound: true);
        m_OnFoot_Crouch = m_OnFoot.FindAction("Crouch", throwIfNotFound: true);
        // OnHand
        m_OnHand = asset.FindActionMap("OnHand", throwIfNotFound: true);
        m_OnHand_Shoot = m_OnHand.FindAction("Shoot", throwIfNotFound: true);
        m_OnHand_Reload = m_OnHand.FindAction("Reload", throwIfNotFound: true);
        m_OnHand_GetFirstWeapon = m_OnHand.FindAction("GetFirstWeapon", throwIfNotFound: true);
        m_OnHand_GetSecondWeapon = m_OnHand.FindAction("GetSecondWeapon", throwIfNotFound: true);
        m_OnHand_GetThirdWeapon = m_OnHand.FindAction("GetThirdWeapon", throwIfNotFound: true);
        m_OnHand_Interact = m_OnHand.FindAction("Interact", throwIfNotFound: true);
        m_OnHand_SwitchWeapon = m_OnHand.FindAction("SwitchWeapon", throwIfNotFound: true);
        m_OnHand_DropWeapon = m_OnHand.FindAction("DropWeapon", throwIfNotFound: true);
        m_OnHand_Aim = m_OnHand.FindAction("Aim", throwIfNotFound: true);
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

    // OnFoot
    private readonly InputActionMap m_OnFoot;
    private IOnFootActions m_OnFootActionsCallbackInterface;
    private readonly InputAction m_OnFoot_Movement;
    private readonly InputAction m_OnFoot_Jump;
    private readonly InputAction m_OnFoot_Look;
    private readonly InputAction m_OnFoot_Sprint;
    private readonly InputAction m_OnFoot_Crouch;
    public struct OnFootActions
    {
        private @PlayerInput m_Wrapper;
        public OnFootActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_OnFoot_Movement;
        public InputAction @Jump => m_Wrapper.m_OnFoot_Jump;
        public InputAction @Look => m_Wrapper.m_OnFoot_Look;
        public InputAction @Sprint => m_Wrapper.m_OnFoot_Sprint;
        public InputAction @Crouch => m_Wrapper.m_OnFoot_Crouch;
        public InputActionMap Get() { return m_Wrapper.m_OnFoot; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OnFootActions set) { return set.Get(); }
        public void SetCallbacks(IOnFootActions instance)
        {
            if (m_Wrapper.m_OnFootActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnJump;
                @Look.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnLook;
                @Sprint.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnSprint;
                @Crouch.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnCrouch;
            }
            m_Wrapper.m_OnFootActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
            }
        }
    }
    public OnFootActions @OnFoot => new OnFootActions(this);

    // OnHand
    private readonly InputActionMap m_OnHand;
    private IOnHandActions m_OnHandActionsCallbackInterface;
    private readonly InputAction m_OnHand_Shoot;
    private readonly InputAction m_OnHand_Reload;
    private readonly InputAction m_OnHand_GetFirstWeapon;
    private readonly InputAction m_OnHand_GetSecondWeapon;
    private readonly InputAction m_OnHand_GetThirdWeapon;
    private readonly InputAction m_OnHand_Interact;
    private readonly InputAction m_OnHand_SwitchWeapon;
    private readonly InputAction m_OnHand_DropWeapon;
    private readonly InputAction m_OnHand_Aim;
    public struct OnHandActions
    {
        private @PlayerInput m_Wrapper;
        public OnHandActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_OnHand_Shoot;
        public InputAction @Reload => m_Wrapper.m_OnHand_Reload;
        public InputAction @GetFirstWeapon => m_Wrapper.m_OnHand_GetFirstWeapon;
        public InputAction @GetSecondWeapon => m_Wrapper.m_OnHand_GetSecondWeapon;
        public InputAction @GetThirdWeapon => m_Wrapper.m_OnHand_GetThirdWeapon;
        public InputAction @Interact => m_Wrapper.m_OnHand_Interact;
        public InputAction @SwitchWeapon => m_Wrapper.m_OnHand_SwitchWeapon;
        public InputAction @DropWeapon => m_Wrapper.m_OnHand_DropWeapon;
        public InputAction @Aim => m_Wrapper.m_OnHand_Aim;
        public InputActionMap Get() { return m_Wrapper.m_OnHand; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OnHandActions set) { return set.Get(); }
        public void SetCallbacks(IOnHandActions instance)
        {
            if (m_Wrapper.m_OnHandActionsCallbackInterface != null)
            {
                @Shoot.started -= m_Wrapper.m_OnHandActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_OnHandActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_OnHandActionsCallbackInterface.OnShoot;
                @Reload.started -= m_Wrapper.m_OnHandActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_OnHandActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_OnHandActionsCallbackInterface.OnReload;
                @GetFirstWeapon.started -= m_Wrapper.m_OnHandActionsCallbackInterface.OnGetFirstWeapon;
                @GetFirstWeapon.performed -= m_Wrapper.m_OnHandActionsCallbackInterface.OnGetFirstWeapon;
                @GetFirstWeapon.canceled -= m_Wrapper.m_OnHandActionsCallbackInterface.OnGetFirstWeapon;
                @GetSecondWeapon.started -= m_Wrapper.m_OnHandActionsCallbackInterface.OnGetSecondWeapon;
                @GetSecondWeapon.performed -= m_Wrapper.m_OnHandActionsCallbackInterface.OnGetSecondWeapon;
                @GetSecondWeapon.canceled -= m_Wrapper.m_OnHandActionsCallbackInterface.OnGetSecondWeapon;
                @GetThirdWeapon.started -= m_Wrapper.m_OnHandActionsCallbackInterface.OnGetThirdWeapon;
                @GetThirdWeapon.performed -= m_Wrapper.m_OnHandActionsCallbackInterface.OnGetThirdWeapon;
                @GetThirdWeapon.canceled -= m_Wrapper.m_OnHandActionsCallbackInterface.OnGetThirdWeapon;
                @Interact.started -= m_Wrapper.m_OnHandActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_OnHandActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_OnHandActionsCallbackInterface.OnInteract;
                @SwitchWeapon.started -= m_Wrapper.m_OnHandActionsCallbackInterface.OnSwitchWeapon;
                @SwitchWeapon.performed -= m_Wrapper.m_OnHandActionsCallbackInterface.OnSwitchWeapon;
                @SwitchWeapon.canceled -= m_Wrapper.m_OnHandActionsCallbackInterface.OnSwitchWeapon;
                @DropWeapon.started -= m_Wrapper.m_OnHandActionsCallbackInterface.OnDropWeapon;
                @DropWeapon.performed -= m_Wrapper.m_OnHandActionsCallbackInterface.OnDropWeapon;
                @DropWeapon.canceled -= m_Wrapper.m_OnHandActionsCallbackInterface.OnDropWeapon;
                @Aim.started -= m_Wrapper.m_OnHandActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_OnHandActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_OnHandActionsCallbackInterface.OnAim;
            }
            m_Wrapper.m_OnHandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
                @GetFirstWeapon.started += instance.OnGetFirstWeapon;
                @GetFirstWeapon.performed += instance.OnGetFirstWeapon;
                @GetFirstWeapon.canceled += instance.OnGetFirstWeapon;
                @GetSecondWeapon.started += instance.OnGetSecondWeapon;
                @GetSecondWeapon.performed += instance.OnGetSecondWeapon;
                @GetSecondWeapon.canceled += instance.OnGetSecondWeapon;
                @GetThirdWeapon.started += instance.OnGetThirdWeapon;
                @GetThirdWeapon.performed += instance.OnGetThirdWeapon;
                @GetThirdWeapon.canceled += instance.OnGetThirdWeapon;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @SwitchWeapon.started += instance.OnSwitchWeapon;
                @SwitchWeapon.performed += instance.OnSwitchWeapon;
                @SwitchWeapon.canceled += instance.OnSwitchWeapon;
                @DropWeapon.started += instance.OnDropWeapon;
                @DropWeapon.performed += instance.OnDropWeapon;
                @DropWeapon.canceled += instance.OnDropWeapon;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
            }
        }
    }
    public OnHandActions @OnHand => new OnHandActions(this);
    public interface IOnFootActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
    }
    public interface IOnHandActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnGetFirstWeapon(InputAction.CallbackContext context);
        void OnGetSecondWeapon(InputAction.CallbackContext context);
        void OnGetThirdWeapon(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnSwitchWeapon(InputAction.CallbackContext context);
        void OnDropWeapon(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
    }
}
