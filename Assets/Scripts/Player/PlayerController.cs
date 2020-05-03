using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public static PlayerController instance;
		
	public float moveSpeed;
	public Rigidbody2D theRB;
	public float jumpForce;

	public bool isJumped;
	public bool isGrounded;
	public Transform groundCheckPoint;
	public LayerMask whatIsGround;
	
	private Animator anim;
	public SpriteRenderer theSR;
	
	public float knockBackLength, knockBackForce;
	private float knockBackCounter;

	private float horizontal;

    public bool isInAttack;
	
	public void Awake()
	{
		instance = this;
	}
	
    void Start()
    {
        anim = GetComponent<Animator>();
		theSR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

		if (knockBackCounter <= 0)
		{
			theRB.velocity = new Vector2(horizontal * moveSpeed, theRB.velocity.y);
			
			isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, .2f, whatIsGround);
			
			if (Input.GetButtonDown("Jump"))
			{
				if (isGrounded)
				{
					theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
				}
			}

            if (Input.GetButtonDown("Attack"))
            {
                StartCoroutine(crashAttack());
                Debug.Log("Launch Attack");
            }
			
			if (theRB.velocity.x < 0)
			{
				theSR.flipX = true;
			} else if(theRB.velocity.x > 0)
			{
				theSR.flipX = false;
			}
		
		} else
		{
			knockBackCounter -= Time.deltaTime;
			if (!theSR.flipX)
			{
				theRB.velocity = new Vector2(-knockBackForce, theRB.velocity.y);
			} else
			{
				theRB.velocity = new Vector2(knockBackForce, theRB.velocity.y);
			}
		}
		
		anim.SetFloat("moveSpeed", Mathf.Abs(theRB.velocity.x));
		anim.SetBool("isGrounded", isGrounded);
        anim.SetBool("isInAttack", isInAttack);
    }
	
	public void knockBack()
	{
		knockBackCounter = knockBackLength;
		theRB.velocity = new Vector2(0f, knockBackForce);
	}

    public void boxJumped()
    {
		theRB.velocity = new Vector2(theRB.velocity.x, jumpForce * 1.5f);
    }

    IEnumerator crashAttack()
    {
        isInAttack = true;
        Debug.Log("Crash is Attacking");
        yield return new WaitForSeconds(1f);
        isInAttack = false;
    }
}
