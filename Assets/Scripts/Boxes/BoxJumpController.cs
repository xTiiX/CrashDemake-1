using UnityEngine;

public class BoxJumpController : MonoBehaviour
{
    private GameObject player;
    private BoxJumpController instance;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player = collision.gameObject;
            Vector2 playerVelocity = player.GetComponent<Rigidbody2D>().velocity;

            var normal = collision.contacts[0].normal;
            if (normal.y < 0)
            {
                PlayerController.instance.boxJumped();
                playerVelocity = new Vector2(playerVelocity.x, playerVelocity.y + 3);
            }
        }
    }
}
