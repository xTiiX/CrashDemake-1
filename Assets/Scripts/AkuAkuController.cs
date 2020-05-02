using UnityEngine;

public class AkuAkuController : MonoBehaviour
{
    public GameObject target;

    public float smoothSpeed = 15f;
    public Vector3 offset;

    private void LateUpdate()
    {
        //Player's direction
        if (target.GetComponent<PlayerController>().theSR.flipX)
        {
            offset = new Vector3(-offset.x, offset.y, offset.z);
        }

        Vector3 finalPos = target.transform.position + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, finalPos, smoothSpeed * Time.deltaTime);

        transform.position = smoothPos;
    }
}
