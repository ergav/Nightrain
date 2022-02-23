//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Scripts/PlayerControls.inputactions
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

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""80058acd-b1d9-4b28-a038-6861047ae303"",
            ""actions"": [
                {
                    ""name"": ""ActionMovement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1b77f72d-e41a-4f65-a21a-714832864dca"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ActionCrouch"",
                    ""type"": ""Button"",
                    ""id"": ""8dcec259-228c-4182-b73c-83c9e7d129f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold,Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""39475ef0-59c6-4905-ad71-f23dcb62a195"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""7563a2c0-04b9-491f-b3d0-5df3c1a24a0e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Scroll"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dee4c1a9-aef2-41f0-aff4-d2c141286b27"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Weapon Change"",
                    ""type"": ""Button"",
                    ""id"": ""ef573a3a-d338-4e35-8e3e-134c46288a1c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Flashlight"",
                    ""type"": ""Button"",
                    ""id"": ""78ec2c11-32df-4a68-906d-51997a90529b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""849c2981-ffd4-4ecc-985a-2069ae72485e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ActionSprint"",
                    ""type"": ""Button"",
                    ""id"": ""dacab7fb-f90a-4baa-aaf5-5af7fced8569"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""b0e056fe-92a5-4e30-bc3c-6ba1a62f508e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ActionReload"",
                    ""type"": ""Button"",
                    ""id"": ""0567ae3a-068d-4a45-9c1c-ee812a0446b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""3cdecb39-4b27-42a9-8acc-b668319ea27c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""54912f6d-804c-4dba-b384-6a3b3d5d3421"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9ad52d15-e68b-4bbb-b321-043599431a85"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fd5e7a7d-e575-4f9d-b85b-bba77fbc5534"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8e0dab88-6717-4416-82a6-7fc98353aafa"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""e206c899-b77b-4670-9307-fb8bd3f7dee8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""afdf5838-bdac-4672-bb12-afaedd15190b"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5eabb99d-b8f3-4b0c-b5f6-75db2b8e634c"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c34dd751-553e-4778-aa7e-6624b4727fe4"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""01effcfd-7da1-4624-8aad-7b9d0ab73d53"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""73d4c29f-7ce4-4226-8f49-d1c29400a398"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionCrouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41baf77b-a2f4-4dcc-aea2-573dc84fb2ca"",
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
                    ""id"": ""b483d051-5b26-4de6-abf8-c4f04f922d85"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07bfac29-c8e7-4203-afe3-5c3ddba16b1e"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb96e053-b19b-423e-a011-dafefc68b841"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Weapon Change"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""584b58c8-8397-4e29-be98-d53857949de2"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Weapon Change"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69bf654d-322e-4a49-ae8e-7079447183c5"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Flashlight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2931a7e6-9633-4aa3-9508-8a2a4a3026b2"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a1e6b94-56e9-41f1-881d-6fcc73a3fbfd"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionSprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c66d2f87-2f80-4545-bb42-0b124ac75724"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""444290db-c97d-42d2-bacf-c98528175d38"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionReload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_ActionMovement = m_Player.FindAction("ActionMovement", throwIfNotFound: true);
        m_Player_ActionCrouch = m_Player.FindAction("ActionCrouch", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_Fire = m_Player.FindAction("Fire", throwIfNotFound: true);
        m_Player_Scroll = m_Player.FindAction("Scroll", throwIfNotFound: true);
        m_Player_WeaponChange = m_Player.FindAction("Weapon Change", throwIfNotFound: true);
        m_Player_Flashlight = m_Player.FindAction("Flashlight", throwIfNotFound: true);
        m_Player_Interaction = m_Player.FindAction("Interaction", throwIfNotFound: true);
        m_Player_ActionSprint = m_Player.FindAction("ActionSprint", throwIfNotFound: true);
        m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
        m_Player_ActionReload = m_Player.FindAction("ActionReload", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_ActionMovement;
    private readonly InputAction m_Player_ActionCrouch;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_Fire;
    private readonly InputAction m_Player_Scroll;
    private readonly InputAction m_Player_WeaponChange;
    private readonly InputAction m_Player_Flashlight;
    private readonly InputAction m_Player_Interaction;
    private readonly InputAction m_Player_ActionSprint;
    private readonly InputAction m_Player_Pause;
    private readonly InputAction m_Player_ActionReload;
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ActionMovement => m_Wrapper.m_Player_ActionMovement;
        public InputAction @ActionCrouch => m_Wrapper.m_Player_ActionCrouch;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Fire => m_Wrapper.m_Player_Fire;
        public InputAction @Scroll => m_Wrapper.m_Player_Scroll;
        public InputAction @WeaponChange => m_Wrapper.m_Player_WeaponChange;
        public InputAction @Flashlight => m_Wrapper.m_Player_Flashlight;
        public InputAction @Interaction => m_Wrapper.m_Player_Interaction;
        public InputAction @ActionSprint => m_Wrapper.m_Player_ActionSprint;
        public InputAction @Pause => m_Wrapper.m_Player_Pause;
        public InputAction @ActionReload => m_Wrapper.m_Player_ActionReload;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @ActionMovement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActionMovement;
                @ActionMovement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActionMovement;
                @ActionMovement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActionMovement;
                @ActionCrouch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActionCrouch;
                @ActionCrouch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActionCrouch;
                @ActionCrouch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActionCrouch;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Fire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Scroll.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScroll;
                @Scroll.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScroll;
                @Scroll.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScroll;
                @WeaponChange.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponChange;
                @WeaponChange.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponChange;
                @WeaponChange.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponChange;
                @Flashlight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFlashlight;
                @Flashlight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFlashlight;
                @Flashlight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFlashlight;
                @Interaction.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteraction;
                @Interaction.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteraction;
                @Interaction.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteraction;
                @ActionSprint.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActionSprint;
                @ActionSprint.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActionSprint;
                @ActionSprint.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActionSprint;
                @Pause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @ActionReload.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActionReload;
                @ActionReload.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActionReload;
                @ActionReload.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActionReload;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ActionMovement.started += instance.OnActionMovement;
                @ActionMovement.performed += instance.OnActionMovement;
                @ActionMovement.canceled += instance.OnActionMovement;
                @ActionCrouch.started += instance.OnActionCrouch;
                @ActionCrouch.performed += instance.OnActionCrouch;
                @ActionCrouch.canceled += instance.OnActionCrouch;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Scroll.started += instance.OnScroll;
                @Scroll.performed += instance.OnScroll;
                @Scroll.canceled += instance.OnScroll;
                @WeaponChange.started += instance.OnWeaponChange;
                @WeaponChange.performed += instance.OnWeaponChange;
                @WeaponChange.canceled += instance.OnWeaponChange;
                @Flashlight.started += instance.OnFlashlight;
                @Flashlight.performed += instance.OnFlashlight;
                @Flashlight.canceled += instance.OnFlashlight;
                @Interaction.started += instance.OnInteraction;
                @Interaction.performed += instance.OnInteraction;
                @Interaction.canceled += instance.OnInteraction;
                @ActionSprint.started += instance.OnActionSprint;
                @ActionSprint.performed += instance.OnActionSprint;
                @ActionSprint.canceled += instance.OnActionSprint;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @ActionReload.started += instance.OnActionReload;
                @ActionReload.performed += instance.OnActionReload;
                @ActionReload.canceled += instance.OnActionReload;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnActionMovement(InputAction.CallbackContext context);
        void OnActionCrouch(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnScroll(InputAction.CallbackContext context);
        void OnWeaponChange(InputAction.CallbackContext context);
        void OnFlashlight(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
        void OnActionSprint(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnActionReload(InputAction.CallbackContext context);
    }
}
