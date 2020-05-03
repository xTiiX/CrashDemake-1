using UnityEngine;

public class PlantController : MonoBehaviour
{
    public static PlantController instance;
    public GameObject wumpa;

    private void Awake()
    {
        instance = this;
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
                GameObject.Destroy(gameObject);
            }
            else
            {
                PlayerHealthController.instance.DealDamage();
            }
        }
    }
}
