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
            PlayerHealthController.instance.explosion();
            GameObject.FindGameObjectWithTag("AkuAku").GetComponent<AkuAkuController>().lives = 0;
            Destroy(gameObject);
        }
    }
}


