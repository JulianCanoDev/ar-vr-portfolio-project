// GENERATED AUTOMATICALLY FROM 'Assets/Player/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GrondMovement"",
            ""id"": ""bb9fe400-53fc-4635-a0f1-4b1d8555489d"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMovement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""51b0c380-8d8c-434a-b232-f49ebecbe54d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""ce5a7a51-1482-46b9-a72c-6899907d890e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TakeObject"",
                    ""type"": ""Button"",
                    ""id"": ""233e8f53-3fa4-4f5d-acb2-c75f03847837"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ThrowObject"",
                    ""type"": ""Button"",
                    ""id"": ""02606d86-1b16-410b-b83f-cc23dd9c11fa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6429c245-f5c9-4dfb-83e2-8f901aa17aa7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""15e4f752-ba0e-494d-86bf-fb51d26d2aa4"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""4785c717-9401-4dc6-8196-d52095d1a962"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""26d0f22d-b6d5-4932-b7c0-f68ea496212f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1e7a2453-75a8-4ffd-9e54-d097e7948aa5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8ed85bd5-c876-40da-a1a5-d2cace6d5cd2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d068f08b-0def-40a0-b3d7-87e334c1cb06"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""3e303625-1d2e-4fb1-a3b4-da6732f063fd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4449c4ac-9a4d-4ad4-83fe-5599a7e64623"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4a8bd4e6-df95-4d4d-80e5-04bb7b446a34"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d0e4f236-2de2-418f-be2f-2676538f2824"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b2269800-8cff-4b28-8eb9-046a006017fa"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6ea0c6d1-6800-4920-a769-e9593c54b00f"",
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
                    ""id"": ""84dddc20-f47c-48f2-a084-ec71a8681645"",
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
                    ""id"": ""f1593051-96ee-41b0-ad2d-39deb289f3da"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TakeObject"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12282f07-d6dd-4ea2-8abe-cd98b914d98c"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TakeObject"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16e1f0ba-d48e-438a-b4a9-815748d6870a"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThrowObject"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5054b653-4855-48af-aea9-3d1ff7f05926"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThrowObject"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e9886ad-680f-4c8f-9199-9b4bbf51da80"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc07e7a7-3ebb-4773-815c-c90f62fcee46"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f37a1023-fa94-4551-89e0-222d53731568"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f94798d-252c-47ff-815a-862255a92cf0"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GrondMovement
        m_GrondMovement = asset.FindActionMap("GrondMovement", throwIfNotFound: true);
        m_GrondMovement_HorizontalMovement = m_GrondMovement.FindAction("HorizontalMovement", throwIfNotFound: true);
        m_GrondMovement_Jump = m_GrondMovement.FindAction("Jump", throwIfNotFound: true);
        m_GrondMovement_TakeObject = m_GrondMovement.FindAction("TakeObject", throwIfNotFound: true);
        m_GrondMovement_ThrowObject = m_GrondMovement.FindAction("ThrowObject", throwIfNotFound: true);
        m_GrondMovement_MouseX = m_GrondMovement.FindAction("MouseX", throwIfNotFound: true);
        m_GrondMovement_MouseY = m_GrondMovement.FindAction("MouseY", throwIfNotFound: true);
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

    // GrondMovement
    private readonly InputActionMap m_GrondMovement;
    private IGrondMovementActions m_GrondMovementActionsCallbackInterface;
    private readonly InputAction m_GrondMovement_HorizontalMovement;
    private readonly InputAction m_GrondMovement_Jump;
    private readonly InputAction m_GrondMovement_TakeObject;
    private readonly InputAction m_GrondMovement_ThrowObject;
    private readonly InputAction m_GrondMovement_MouseX;
    private readonly InputAction m_GrondMovement_MouseY;
    public struct GrondMovementActions
    {
        private @PlayerControls m_Wrapper;
        public GrondMovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMovement => m_Wrapper.m_GrondMovement_HorizontalMovement;
        public InputAction @Jump => m_Wrapper.m_GrondMovement_Jump;
        public InputAction @TakeObject => m_Wrapper.m_GrondMovement_TakeObject;
        public InputAction @ThrowObject => m_Wrapper.m_GrondMovement_ThrowObject;
        public InputAction @MouseX => m_Wrapper.m_GrondMovement_MouseX;
        public InputAction @MouseY => m_Wrapper.m_GrondMovement_MouseY;
        public InputActionMap Get() { return m_Wrapper.m_GrondMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GrondMovementActions set) { return set.Get(); }
        public void SetCallbacks(IGrondMovementActions instance)
        {
            if (m_Wrapper.m_GrondMovementActionsCallbackInterface != null)
            {
                @HorizontalMovement.started -= m_Wrapper.m_GrondMovementActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.performed -= m_Wrapper.m_GrondMovementActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.canceled -= m_Wrapper.m_GrondMovementActionsCallbackInterface.OnHorizontalMovement;
                @Jump.started -= m_Wrapper.m_GrondMovementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GrondMovementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GrondMovementActionsCallbackInterface.OnJump;
                @TakeObject.started -= m_Wrapper.m_GrondMovementActionsCallbackInterface.OnTakeObject;
                @TakeObject.performed -= m_Wrapper.m_GrondMovementActionsCallbackInterface.OnTakeObject;
                @TakeObject.canceled -= m_Wrapper.m_GrondMovementActionsCallbackInterface.OnTakeObject;
                @ThrowObject.started -= m_Wrapper.m_GrondMovementActionsCallbackInterface.OnThrowObject;
                @ThrowObject.performed -= m_Wrapper.m_GrondMovementActionsCallbackInterface.OnThrowObject;
                @ThrowObject.canceled -= m_Wrapper.m_GrondMovementActionsCallbackInterface.OnThrowObject;
                @MouseX.started -= m_Wrapper.m_GrondMovementActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_GrondMovementActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_GrondMovementActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_GrondMovementActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_GrondMovementActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_GrondMovementActionsCallbackInterface.OnMouseY;
            }
            m_Wrapper.m_GrondMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalMovement.started += instance.OnHorizontalMovement;
                @HorizontalMovement.performed += instance.OnHorizontalMovement;
                @HorizontalMovement.canceled += instance.OnHorizontalMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @TakeObject.started += instance.OnTakeObject;
                @TakeObject.performed += instance.OnTakeObject;
                @TakeObject.canceled += instance.OnTakeObject;
                @ThrowObject.started += instance.OnThrowObject;
                @ThrowObject.performed += instance.OnThrowObject;
                @ThrowObject.canceled += instance.OnThrowObject;
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
            }
        }
    }
    public GrondMovementActions @GrondMovement => new GrondMovementActions(this);
    public interface IGrondMovementActions
    {
        void OnHorizontalMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnTakeObject(InputAction.CallbackContext context);
        void OnThrowObject(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
    }
}
