using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
	public float moveSpeed;
	
	public Transform leftPoint, rightPoint;
	
	private bool movingRight;
	
	private Rigidbody2D theRB;
	public SpriteRenderer theSR;
    // Start is called before the first frame update
    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();
		
		leftPoint.parent = null;
		rightPoint.parent = null;
		
		movingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(movingRight)
		{
			theRB.velocity = new Vector2(moveSpeed, theRB.velocity.y);
			
			theSR.flipX = true;
			
			if(transform.position.x > rightPoint.position.x)
			{
				movingRight = false;
			}
		}else
		{
			theRB.velocity = new Vector2(-moveSpeed, theRB.velocity.y);
			
			theSR.flipX = false;
			
			if(transform.position.x < leftPoint.position.x)
			{
				movingRight = true;
			}
		}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        EnemyCollide(collision);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        EnemyCollide(collision);
    }

    public void EnemyCollide(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.GetComponent<PlayerController>().isInAttack)
            {
                Destroy(gameObject);
            }
            else
            {
                PlayerHealthController.instance.DealDamage();
            }
        }
    }
}
