using UnityEngine;

public class AkuAkuController : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 5f;
    public Vector3 offset;

    private void LateUpdate()
    {
        Vector3 finalPos = target.position + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, finalPos, smoothSpeed * Time.deltaTime);

        transform.position = smoothPos;
    }
}
