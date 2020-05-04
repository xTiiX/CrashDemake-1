using UnityEngine;

public class BoxAkuAkuController : MonoBehaviour
{
    public static BoxAkuAkuController instance;
    public GameObject akuAkuLife;

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
                Destroy(gameObject);
                akuAkuLife.SetActive(true);
            }
        }
    }
}
