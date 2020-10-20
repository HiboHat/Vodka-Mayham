// GENERATED AUTOMATICALLY FROM 'Assets/Script/Input/InputLibrary.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputLibrary : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputLibrary()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputLibrary"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""220536f7-3609-4ed6-b5b3-464af15e9cbf"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""f1827479-5ab0-4c6b-b229-3995ec238061"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""e52aaba5-ef31-42f1-a24f-466590d4d579"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""Normalize(max=1)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""e6894cde-887d-4192-bd29-c2bdaa076dd2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""06159fc1-dc67-48f7-82d2-6be66b62071e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WeaponSlot1"",
                    ""type"": ""Button"",
                    ""id"": ""d7987139-18a2-486e-8803-84401a950235"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WeaponSlot2"",
                    ""type"": ""Button"",
                    ""id"": ""57817b59-f28f-46d3-bc74-ef81dce080c7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WeaponSlot3"",
                    ""type"": ""Button"",
                    ""id"": ""a53890e6-2118-4c78-8f7b-7e898f39f480"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WeaponSlot4"",
                    ""type"": ""Button"",
                    ""id"": ""7e6cbffd-77c1-4926-93d0-3f58976e5d7a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""14ac5bbf-5fdb-48cd-83e9-60cfb1dd10f5"",
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
                    ""id"": ""6fe6dc9e-d6d5-4748-aa42-b20aeafdba13"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Horizontal"",
                    ""id"": ""e0643041-1ff4-45eb-971e-7ab18cab2279"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""aba81442-4a14-4e38-a9d9-ec5cd4bb01aa"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5016a85c-e672-43fc-8bf8-b477f951e76b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""07c82000-42ac-48df-a9f8-dc8fbf14aa85"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e65ef0b-37d7-416d-87e9-b9bdb6cd04ad"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponSlot1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f6a6430-d272-4ad7-bf9c-8227bddab99e"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponSlot2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2040cefc-598e-40dc-b5f7-69f25cdae53f"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponSlot3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aeb091eb-1f31-4377-8daf-2597a0eb145d"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponSlot4"",
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
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_Fire = m_Player.FindAction("Fire", throwIfNotFound: true);
        m_Player_WeaponSlot1 = m_Player.FindAction("WeaponSlot1", throwIfNotFound: true);
        m_Player_WeaponSlot2 = m_Player.FindAction("WeaponSlot2", throwIfNotFound: true);
        m_Player_WeaponSlot3 = m_Player.FindAction("WeaponSlot3", throwIfNotFound: true);
        m_Player_WeaponSlot4 = m_Player.FindAction("WeaponSlot4", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_Fire;
    private readonly InputAction m_Player_WeaponSlot1;
    private readonly InputAction m_Player_WeaponSlot2;
    private readonly InputAction m_Player_WeaponSlot3;
    private readonly InputAction m_Player_WeaponSlot4;
    public struct PlayerActions
    {
        private @InputLibrary m_Wrapper;
        public PlayerActions(@InputLibrary wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Fire => m_Wrapper.m_Player_Fire;
        public InputAction @WeaponSlot1 => m_Wrapper.m_Player_WeaponSlot1;
        public InputAction @WeaponSlot2 => m_Wrapper.m_Player_WeaponSlot2;
        public InputAction @WeaponSlot3 => m_Wrapper.m_Player_WeaponSlot3;
        public InputAction @WeaponSlot4 => m_Wrapper.m_Player_WeaponSlot4;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Fire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @WeaponSlot1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSlot1;
                @WeaponSlot1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSlot1;
                @WeaponSlot1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSlot1;
                @WeaponSlot2.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSlot2;
                @WeaponSlot2.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSlot2;
                @WeaponSlot2.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSlot2;
                @WeaponSlot3.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSlot3;
                @WeaponSlot3.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSlot3;
                @WeaponSlot3.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSlot3;
                @WeaponSlot4.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSlot4;
                @WeaponSlot4.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSlot4;
                @WeaponSlot4.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSlot4;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @WeaponSlot1.started += instance.OnWeaponSlot1;
                @WeaponSlot1.performed += instance.OnWeaponSlot1;
                @WeaponSlot1.canceled += instance.OnWeaponSlot1;
                @WeaponSlot2.started += instance.OnWeaponSlot2;
                @WeaponSlot2.performed += instance.OnWeaponSlot2;
                @WeaponSlot2.canceled += instance.OnWeaponSlot2;
                @WeaponSlot3.started += instance.OnWeaponSlot3;
                @WeaponSlot3.performed += instance.OnWeaponSlot3;
                @WeaponSlot3.canceled += instance.OnWeaponSlot3;
                @WeaponSlot4.started += instance.OnWeaponSlot4;
                @WeaponSlot4.performed += instance.OnWeaponSlot4;
                @WeaponSlot4.canceled += instance.OnWeaponSlot4;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnWeaponSlot1(InputAction.CallbackContext context);
        void OnWeaponSlot2(InputAction.CallbackContext context);
        void OnWeaponSlot3(InputAction.CallbackContext context);
        void OnWeaponSlot4(InputAction.CallbackContext context);
    }
}
