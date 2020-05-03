using UnityEngine;
using System.Collections;

public class BoxBasicController : MonoBehaviour
{
    public GameObject crash;
    public GameObject wumpa;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(collider.tag);
        if (collider.tag == "Player")
        {
            if (crash.GetComponent<PlayerController>().isInAttack)
            {
                wumpa.SetActive(true);
                Destroy(gameObject);
            }
        }
    }
}
