using UnityEngine;

public class CrashCamera : MonoBehaviour
{
    public GameObject crash;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(crash.transform.position.x, 0, -10);
    }
}
