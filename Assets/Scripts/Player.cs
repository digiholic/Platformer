using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private PlatformerCharacterController controller;

    private PlatformerMainInput inputs;
    [SerializeField] private InputPackage inputsThisFrame = new InputPackage();

    private void Awake()
    {
        if (inputs == null) inputs = new PlatformerMainInput();

        inputs.Overworld.Move.performed   += MovePerformed;
        inputs.Overworld.Camera.performed += CameraPerformed;
        inputs.Overworld.Jump.started     += JumpPerformed;
        inputs.Overworld.Jump.canceled    += JumpPerformed;
        inputs.Overworld.Crouch.started   += CrouchPerformed;
        inputs.Overworld.Crouch.canceled  += CrouchPerformed;
        inputs.Overworld.Action.started   += ActionPerformed;
        inputs.Overworld.Action.canceled  += ActionPerformed;

        inputs.Overworld.Action.Enable();

    }

    private void OnDestroy()
    {
        inputs.Overworld.Move.performed   -= MovePerformed;
        inputs.Overworld.Camera.performed -= CameraPerformed;
        inputs.Overworld.Jump.started     -= JumpPerformed;
        inputs.Overworld.Jump.canceled    -= JumpPerformed;
        inputs.Overworld.Crouch.started   -= CrouchPerformed;
        inputs.Overworld.Crouch.canceled  -= CrouchPerformed;
        inputs.Overworld.Action.started   -= ActionPerformed;
        inputs.Overworld.Action.canceled  -= ActionPerformed;
    }

    private void OnEnable() => inputs.Enable();
    private void OnDisable() => inputs.Disable();

    private void ActionPerformed(InputAction.CallbackContext context)
    {
        inputsThisFrame.actionPressed = context.started;
        inputsThisFrame.actionReleased = context.canceled;
    }

    private void CrouchPerformed(InputAction.CallbackContext context)
    {
        inputsThisFrame.crouchPressed = context.started;
        inputsThisFrame.crouchReleased = context.canceled;
    }

    private void JumpPerformed(InputAction.CallbackContext context)
    {
        inputsThisFrame.jumpPressed = context.started;
        inputsThisFrame.jumpReleased = context.canceled;
    }

    private void CameraPerformed(InputAction.CallbackContext context)
    {
        inputsThisFrame.Aim = context.ReadValue<Vector2>();
    }

    private void MovePerformed(InputAction.CallbackContext context)
    {
        inputsThisFrame.Move = context.ReadValue<Vector2>();
    }

    private void Update()
    {
        //Send Input Package
        inputsThisFrame = new InputPackage();
        inputsThisFrame.actionHeld = inputs.Overworld.Action.IsPressed();


    }
}
