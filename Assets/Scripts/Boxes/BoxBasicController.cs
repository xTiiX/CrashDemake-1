using UnityEngine;

public class BoxBasicController : MonoBehaviour
{
    public GameObject crash;
    public GameObject wumpa;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(collider.tag);
        if (collider.tag == "Player")
        {
            if (crash.GetComponent<PlayerController>().isAttacking)
            {
                wumpa.SetActive(true);
                GameObject.Destroy(gameObject);
            }
        }
    }
}
