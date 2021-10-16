// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControlls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace TheLostVikings
{
    public class @PlayerControlls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerControlls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControlls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""1f4652b5-5e02-441c-8ae3-e8d4178fe4e5"",
            ""actions"": [
                {
                    ""name"": ""Action1"",
                    ""type"": ""Button"",
                    ""id"": ""043d9d0a-d653-404f-8adb-c81d753e0942"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action2"",
                    ""type"": ""Button"",
                    ""id"": ""2a10ed96-ab2b-416b-a0c4-e11cf4cd8f07"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UseItem"",
                    ""type"": ""Button"",
                    ""id"": ""2f8e615b-e707-4dda-a95c-684eca102b6a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""0edd83be-8602-4bce-9a61-bfa7d7e5607d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""a4bed8b5-800d-402c-91ac-e2cffa3c4426"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""eecd46a6-c2c8-4843-8d4a-93c0d68e7df0"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7adc5923-55b6-4517-b9ce-90aa7adb2bb9"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d120357-70e2-427b-abd6-5d5d577ef207"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69565ef2-dd66-4769-80c6-6d18dca1a328"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6680c8d8-3d66-4ce5-aada-0ec314129e6f"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UseItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb4c9007-54a3-47a0-8a5c-03871106f223"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UseItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""622808d6-30d3-4b00-941c-302249ca45d6"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4fbe96af-924f-468f-9864-16dcc2cb4ea0"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""360b9603-2974-436c-aefe-3310da62d451"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""d3a6af74-d80e-4498-b7f8-fee779b133da"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7d49d4d2-31e2-43ed-982e-938e3e55e074"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4b6701ec-273e-4689-a603-39b04760903f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3130d57c-14af-4f96-9370-e89291c3cdd8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""cd7c89f8-1822-4029-a803-4a3020f733d9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Gameplay
            m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
            m_Gameplay_Action1 = m_Gameplay.FindAction("Action1", throwIfNotFound: true);
            m_Gameplay_Action2 = m_Gameplay.FindAction("Action2", throwIfNotFound: true);
            m_Gameplay_UseItem = m_Gameplay.FindAction("UseItem", throwIfNotFound: true);
            m_Gameplay_Use = m_Gameplay.FindAction("Use", throwIfNotFound: true);
            m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
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

        // Gameplay
        private readonly InputActionMap m_Gameplay;
        private IGameplayActions m_GameplayActionsCallbackInterface;
        private readonly InputAction m_Gameplay_Action1;
        private readonly InputAction m_Gameplay_Action2;
        private readonly InputAction m_Gameplay_UseItem;
        private readonly InputAction m_Gameplay_Use;
        private readonly InputAction m_Gameplay_Move;
        public struct GameplayActions
        {
            private @PlayerControlls m_Wrapper;
            public GameplayActions(@PlayerControlls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Action1 => m_Wrapper.m_Gameplay_Action1;
            public InputAction @Action2 => m_Wrapper.m_Gameplay_Action2;
            public InputAction @UseItem => m_Wrapper.m_Gameplay_UseItem;
            public InputAction @Use => m_Wrapper.m_Gameplay_Use;
            public InputAction @Move => m_Wrapper.m_Gameplay_Move;
            public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
            public void SetCallbacks(IGameplayActions instance)
            {
                if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
                {
                    @Action1.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAction1;
                    @Action1.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAction1;
                    @Action1.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAction1;
                    @Action2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAction2;
                    @Action2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAction2;
                    @Action2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAction2;
                    @UseItem.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUseItem;
                    @UseItem.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUseItem;
                    @UseItem.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUseItem;
                    @Use.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUse;
                    @Use.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUse;
                    @Use.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUse;
                    @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                }
                m_Wrapper.m_GameplayActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Action1.started += instance.OnAction1;
                    @Action1.performed += instance.OnAction1;
                    @Action1.canceled += instance.OnAction1;
                    @Action2.started += instance.OnAction2;
                    @Action2.performed += instance.OnAction2;
                    @Action2.canceled += instance.OnAction2;
                    @UseItem.started += instance.OnUseItem;
                    @UseItem.performed += instance.OnUseItem;
                    @UseItem.canceled += instance.OnUseItem;
                    @Use.started += instance.OnUse;
                    @Use.performed += instance.OnUse;
                    @Use.canceled += instance.OnUse;
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                }
            }
        }
        public GameplayActions @Gameplay => new GameplayActions(this);
        public interface IGameplayActions
        {
            void OnAction1(InputAction.CallbackContext context);
            void OnAction2(InputAction.CallbackContext context);
            void OnUseItem(InputAction.CallbackContext context);
            void OnUse(InputAction.CallbackContext context);
            void OnMove(InputAction.CallbackContext context);
        }
    }
}
