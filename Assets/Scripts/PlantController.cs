using UnityEngine;

public class PlantController : MonoBehaviour
{

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
                Destroy(gameObject);
            }
            else
            {
                PlayerHealthController.instance.DealDamage();
            }
        }
    }
}