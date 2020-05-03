using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController instance;

	public Transform target;

    private float positionY;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    void Update()
    {
        print(PlayerController.instance.isJumped);
        if (PlayerController.instance.isJumped)
        {
            positionY = target.position.y;
        } else
        {
            positionY = transform.position.y;
        }

       transform.position = new Vector3(target.position.x, positionY, transform.position.z); 
    }
}
