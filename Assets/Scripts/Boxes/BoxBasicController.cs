using UnityEngine;

public class BoxBasicController : MonoBehaviour
{
    public static BoxBasicController instance;

    public GameObject crash;
    public GameObject wumpa;

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
        if(collision.gameObject.CompareTag("Player"))
        {
            if (crash.GetComponent<PlayerController>().isInAttack)
            {
                Destroy(gameObject);
                wumpa.SetActive(true);
            }
        }
    }
}
