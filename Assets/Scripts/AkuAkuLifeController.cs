using UnityEngine;

public class AkuAkuLifeController : MonoBehaviour
{
    public static AkuAkuLifeController instance;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AkuAkuController.instance.NewAkuAku();
            Destroy(gameObject);
        }
    }
}
