using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Weapons;

public class InputListener : MonoBehaviour, InputLibrary.IPlayerActions
{
    [SerializeField] private Player player = null;
    [SerializeField] private MovementManager movement = null;
    private InputLibrary.PlayerActions playerActions;
    private InputLibrary inputLibrary;
    private float currentXDirection = 0;

    public void Awake()
    {
        inputLibrary = new InputLibrary();
        playerActions = new InputLibrary.PlayerActions(inputLibrary);
        playerActions.SetCallbacks(this);
    }

    public void Update() 
    {
        movement.Move(currentXDirection);
    }

    public void OnEnable()
    {
        playerActions.Enable();
    }

    public void OnDisable()
    {
        playerActions.Disable();
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        if (context.performed)
            player.Fire();
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
            player.OnHit(new Weapons.TestGun(-1));
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if(context.performed)
            movement.Jump();
    }

    public void OnMove(InputAction.CallbackContext context)
    {

        currentXDirection = context.ReadValue<float>();
    }

    public void OnWeaponSlot1(InputAction.CallbackContext context)
    {
        player.GetGunSlots().SwapWeapon(new Weapons.TestGun(-1));
    }

    public void OnWeaponSlot2(InputAction.CallbackContext context)
    {
        player.GetGunSlots().SwapWeapon(new Fist());
    }

    public void OnWeaponSlot3(InputAction.CallbackContext context)
    {

    }

    public void OnWeaponSlot4(InputAction.CallbackContext context)
    {

    }
}
