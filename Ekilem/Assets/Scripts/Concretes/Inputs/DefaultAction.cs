// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Concretes/Inputs/DefaultAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Ekilem
{
    public class @DefaultAction : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @DefaultAction()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultAction"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""b648d1c0-29df-4a5d-96cf-cbb6afd1a71e"",
            ""actions"": [
                {
                    ""name"": ""MoveForward"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a5d570f7-b746-4acb-a18c-5992c45da1ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""12662fe9-6f03-4ae2-8433-281b8a6d2a3d"",
                    ""path"": ""<Keyboard>/#(W)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveForward"",
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
            m_Player_MoveForward = m_Player.FindAction("MoveForward", throwIfNotFound: true);
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
        private readonly InputAction m_Player_MoveForward;
        public struct PlayerActions
        {
            private @DefaultAction m_Wrapper;
            public PlayerActions(@DefaultAction wrapper) { m_Wrapper = wrapper; }
            public InputAction @MoveForward => m_Wrapper.m_Player_MoveForward;
            public InputActionMap Get() { return m_Wrapper.m_Player; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerActions instance)
            {
                if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
                {
                    @MoveForward.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveForward;
                    @MoveForward.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveForward;
                    @MoveForward.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveForward;
                }
                m_Wrapper.m_PlayerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @MoveForward.started += instance.OnMoveForward;
                    @MoveForward.performed += instance.OnMoveForward;
                    @MoveForward.canceled += instance.OnMoveForward;
                }
            }
        }
        public PlayerActions @Player => new PlayerActions(this);
        public interface IPlayerActions
        {
            void OnMoveForward(InputAction.CallbackContext context);
        }
    }
}
