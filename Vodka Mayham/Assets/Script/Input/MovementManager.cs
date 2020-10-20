using UnityEngine;

public class MovementManager : MonoBehaviour
{
    [SerializeField] private Collider2D playerHitBox = null;
    [SerializeField] private Rigidbody2D playerBody = null;
    [SerializeField] private float jumpForce = 100;
    [SerializeField] private float movementSpeed = 10;

    private bool canJump = true;
    public void Move(float _movement) 
    {
        playerBody.velocity = new Vector2(_movement * movementSpeed, playerBody.velocity.y);
    }
    public void Jump() 
    {
            playerBody.AddForce(new Vector2(0, jumpForce));
    }

    public void Crouch(bool _tryCrouch) 
    {
        //TODO crouching
        Debug.LogWarning("Crouch not implemented yet");
    }
}
