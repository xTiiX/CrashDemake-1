using UnityEngine;

public class BoxJumpController : MonoBehaviour
{
    private GameObject player;
    private BoxJumpController instance;

    private Vector2 normal;

    private void Awake()
    {
        instance = this;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player = collision.gameObject;
            Vector2 playerVelocity = player.GetComponent<Rigidbody2D>().velocity;

            normal = collision.contacts[0].normal;
            if (normal.y < 0)
            {
                PlayerController.instance.boxJumped();
                playerVelocity = new Vector2(playerVelocity.x, playerVelocity.y + 3);
            } else if (PlayerController.instance.isInAttack)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (PlayerController.instance.isInAttack)
            {
                Destroy(gameObject);
            }            
        }
    }
}
