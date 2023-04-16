using UnityEngine;

public class playermovement : MonoBehaviour
{
    private float horizontal;
    public float JumpPower = 10f;

    public Rigidbody2D rb;
    public Transform groundcheck;
    public LayerMask groundlayer;
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if(Input.GetButton("Jump") && IsGrounded()){
            rb.velocity = new Vector2(rb.velocity.x,JumpPower);
        }
    }

    public bool IsGrounded(){
        return Physics2D.OverlapCircle(groundcheck.position,0.2f,groundlayer);
    }

    
}
