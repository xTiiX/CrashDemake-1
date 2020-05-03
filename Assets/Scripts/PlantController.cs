using UnityEngine;

public class PlantController : MonoBehaviour
{
    public int lives = 1;
    public GameObject crash;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (crash.GetComponent<PlayerController>().isInAttack)
            {
                GameObject.Destroy(gameObject);
            } 
            else 
            {
                PlayerHealthController.instance.DealDamage();
            }
        }
    }
}
