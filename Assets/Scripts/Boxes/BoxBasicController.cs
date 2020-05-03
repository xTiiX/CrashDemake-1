using UnityEngine;
using System.Collections;

public class BoxBasicController : MonoBehaviour
{
    public GameObject crash;
    public GameObject wumpa;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == crash)
        {
            if (crash.GetComponent<PlayerController>().isInAttack)
            {
                wumpa.SetActive(true);
                Destroy(gameObject);
            }
        }
    }
}
