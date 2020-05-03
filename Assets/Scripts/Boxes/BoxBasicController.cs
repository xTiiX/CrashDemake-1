using UnityEngine;

public class BoxBasicController : MonoBehaviour
{
    public GameObject crash;
    public GameObject wumpa;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (crash.GetComponent<PlayerController>().isAttacking)
            {
                wumpa.SetActive(true);
                GameObject.Destroy(gameObject);
            }
        }
    }
}
