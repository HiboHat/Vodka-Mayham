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
    private bool fireActionIsPressed = false;
    private static Vector2 mousePosition = Vector2.zero;

    public void Awake()
    {
        inputLibrary = new InputLibrary();
        playerActions = new InputLibrary.PlayerActions(inputLibrary);
        playerActions.SetCallbacks(this);
    }

    public void FixedUpdate() 
    {
        movement.Move(currentXDirection);
        if (fireActionIsPressed)
            player.Fire();
    }

    public void OnEnable()
    {
        playerActions.Enable();
    }

    public void OnDisable()
    {
        playerActions.Disable();
    }

    public static Vector3 MouseWorldPosition() 
    {
        return mousePosition;
    }

    public static Vector3 MouseScreenPosition() 
    {
        return Camera.main.ScreenToWorldPoint(mousePosition);
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        fireActionIsPressed = context.performed;

        if (context.canceled)
            player.GetGunSlots().equippedWeapon.ResetFireCount();
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        //Debugging, chance later
        if (context.performed)
            player.GetGunSlots().equippedWeapon.ToggleFireMode();
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
        if (context.performed)
            player.GetGunSlots().SwapWeapon(0);
    }

    public void OnWeaponSlot2(InputAction.CallbackContext context)
    {
        if (context.performed)
            player.GetGunSlots().SwapWeapon(1);
    }

    public void OnWeaponSlot3(InputAction.CallbackContext context)
    {
        if (context.performed)
            player.GetGunSlots().SwapWeapon(2);
    }

    public void OnWeaponSlot4(InputAction.CallbackContext context)
    {
        if (context.performed)
            player.GetGunSlots().SwapWeapon(3);
    }

    public void OnReload(InputAction.CallbackContext context)
    {
        if(context.performed)
            player.GetGunSlots().equippedWeapon.Reload();
    }

    public void OnMousePosition(InputAction.CallbackContext context)
    {
        mousePosition = context.ReadValue<Vector2>();
    }
}
