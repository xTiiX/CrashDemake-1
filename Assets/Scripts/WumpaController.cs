using UnityEngine;
using UnityEngine.UI;

public class WumpaController : MonoBehaviour
{
    public static WumpaController instance;
    public int value = 1;

    private GameObject UI;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UI = GameObject.FindGameObjectWithTag("WumpaAmount");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            int wumpaUI = int.Parse(UI.GetComponent<Text>().text) + value;
            UI.GetComponent<Text>().text = wumpaUI + "";
            Destroy(gameObject);

            if (wumpaUI == 3) // 100 default
            {
                PlayerHealthController.instance.WinLife();
            }
        }
    }
}
