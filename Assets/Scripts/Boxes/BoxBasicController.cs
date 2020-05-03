using UnityEngine;

public class BoxBasicController : MonoBehaviour
{
    public int lives = 1;
    public GameObject crash;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (crash.GetComponent<PlayerController>().isAttacking)
            {
                GameObject.Destroy(gameObject);
            }
        }
    }
}
