using UnityEngine;

public class PointOfLifeController : MonoBehaviour
{
    public static PointOfLifeController instance;

    private void Awake()
    {
        instance = this;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealthController.instance.WinLife();
            Destroy(gameObject);
        }
    }
}
