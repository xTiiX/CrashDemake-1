using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AkuAkuController : MonoBehaviour
{
    public Transform crash;

    public float smoothSpeed = 5f;
    public Vector3 offset;

    void LateUpdate()
    {

        Vector3 finalPos = crash.position + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, finalPos, smoothSpeed * Time.deltaTime);

        transform.position = smoothPos;
    }
}
