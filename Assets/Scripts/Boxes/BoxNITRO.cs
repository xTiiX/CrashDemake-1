using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxNITRO : MonoBehaviour
{
    public GameObject crash;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            crash.GetComponent<PlayerHealthController>().DealDamage();
        }
    }
}
