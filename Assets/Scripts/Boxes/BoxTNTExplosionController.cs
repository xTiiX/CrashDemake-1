using UnityEngine;

public class BoxTNTExplosionController : MonoBehaviour
{
    private bool playerDead = false;
    private bool parentIsExplose;

    private void FixedUpdate()
    {
        parentIsExplose = BoxTNTController.instance.isExplose;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player") && !collision.gameObject.CompareTag("Ground") && collision && parentIsExplose)
        {
            Destroy(collision.gameObject);
        } else if (collision.gameObject.CompareTag("Player") && parentIsExplose && !playerDead)
        {
            PlayerHealthController.instance.DealDamage();
            playerDead = true;
        } else if (parentIsExplose)
        {
            BoxTNTController.instance.isExplose = false;
            Destroy(BoxTNTController.instance.gameObject);
        }
    }

}
