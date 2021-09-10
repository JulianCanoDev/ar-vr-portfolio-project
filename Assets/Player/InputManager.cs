using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private Movement movement;
    [SerializeField] private MouseLook mouseLook;
    
    // Start is called before the first frame update
    private PlayerControls controls;
    private PlayerControls.GrondMovementActions groundMovement;
    private Vector2 horozontalInput;
    private Vector2 mouseInput;

    private void Awake()
    {
        controls = new PlayerControls();
        groundMovement = controls.GrondMovement;
        groundMovement.HorizontalMovement.performed += ctx => horozontalInput = ctx.ReadValue<Vector2>();
        groundMovement.Jump.performed += _ => movement.OnjumpPressed();
        groundMovement.MouseX.performed += ctx => mouseInput.x = ctx.ReadValue<float>();
        groundMovement.MouseY.performed += ctx => mouseInput.y = ctx.ReadValue<float>();
    }

    private void Update()
    {
        movement.RecieveInput(horozontalInput);
        mouseLook.RecieveInput(mouseInput);
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
