using UnityEngine;

public class BoxNITROController : MonoBehaviour
{
    public static BoxNITROController instance;

    private void Awake()
    {
        instance = this;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BoxDestroy(collision);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        BoxDestroy(collision);
    }

    public void BoxDestroy(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.GetComponent<PlayerController>().isInAttack)
            {
                collision.gameObject.GetComponent<PlayerHealthController>().DealDamage();
                Destroy(gameObject);
            }
        }
    }
}


