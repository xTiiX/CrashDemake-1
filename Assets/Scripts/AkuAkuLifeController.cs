using UnityEngine;

public class AkuAkuLifeController : MonoBehaviour
{
    public static AkuAkuLifeController instance;
    public GameObject akuAku;

    private void Awake()
    {
        instance = this;
        akuAku = GameObject.FindGameObjectWithTag("AkuAku");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (akuAku.GetComponent<AkuAkuController>().lives <= 0)
            {
                akuAku.SetActive(true);
                akuAku.GetComponent<AkuAkuController>().lives++;
                Destroy(gameObject);
            }
            else if (akuAku.GetComponent<AkuAkuController>().lives <= 2)
            {
                akuAku.GetComponent<AkuAkuController>().lives++;
                Destroy(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
