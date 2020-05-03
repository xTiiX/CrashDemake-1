using System.Collections;
using UnityEngine;

public class BoxTNT : MonoBehaviour
{
    public GameObject crash;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            StartCoroutine(explosion());
            if (collider.tag == "Player")
            {
                crash.GetComponent<PlayerHealthController>().DealDamage();
            }
        }
    }

    IEnumerator explosion()
    {
        yield return new WaitForSecondsRealtime(3f);
    }
}
