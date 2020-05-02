using UnityEngine;

public class CrashController : MonoBehaviour
{
    public Rigidbody2D rb2d;

    public int moveSpeed;
    public int jumpSpeed;

    private bool isGrounded = false;

    private float horizontal;

    void Start()
    {
        
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        CrashMove(horizontal, moveSpeed);

        if (Input.GetKeyDown("space") && isGrounded)
        {
            CrashJump(jumpSpeed);
        }
    }

    private void CrashMove(float _horizontal, int _moveSpeed)
    {
        rb2d.velocity = new Vector2(_horizontal * _moveSpeed, rb2d.velocity.y);
    }

    private void CrashJump(int _jumpSpeed)
    {
        rb2d.velocity = new Vector2(0, jumpSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
