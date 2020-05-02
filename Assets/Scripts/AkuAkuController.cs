using UnityEngine;

public class AkuAkuController : MonoBehaviour
{
    public GameObject target;

    public float smoothSpeed = 15f;
    public Vector3 offset;

    private int left = 2;
    private int right = -2;

    private void LateUpdate()
    {
        //Player's direction
        if (target.GetComponent<PlayerController>().theSR.flipX)
        {
            offset = new Vector3(left, offset.y, offset.z);
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
        else
        {
            offset = new Vector3(right, offset.y, offset.z);
            transform.rotation = new Quaternion(0,180,0,0);

        }

        Vector3 finalPos = target.transform.position + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, finalPos, smoothSpeed * Time.deltaTime);

        transform.position = smoothPos;
    }
}