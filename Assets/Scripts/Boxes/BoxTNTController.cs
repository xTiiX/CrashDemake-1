using UnityEngine;
using System.Collections;

public class BoxTNTController : MonoBehaviour
{
    public static BoxTNTController instance;

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
            if (collision.gameObject.CompareTag("Player"))
            {
                collision.gameObject.GetComponent<PlayerHealthController>().DealDamage();
            }
        }
    }

    IEnumerator explosion()
    {
        yield return new WaitForSecondsRealtime(3f);
    }
}