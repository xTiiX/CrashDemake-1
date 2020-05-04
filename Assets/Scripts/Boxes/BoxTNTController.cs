using UnityEngine;
using System.Collections;

public class BoxTNTController : MonoBehaviour
{
    public static BoxTNTController instance;
    private bool corout = false;

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
            StartCoroutine(explosion());
        }
    }

    IEnumerator explosion()
    {
        yield return new WaitForSeconds(3f);
    }
}