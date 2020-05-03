using UnityEngine;

public class CameraController : MonoBehaviour
{
	public Transform target;
	
	public Transform farBackground, middleBackground;
	
	private float lastXPos;
    private float lastYPos;
    
    void Start()
    {
        lastXPos = transform.position.x;
        lastYPos = transform.position.y;
    }

    void Update()
    {
        if (target.position.y < 0)
        {
            transform.position = new Vector3(target.position.x, 0, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
        } 
	   
	    float amountToMoveX = transform.position.x - lastXPos;
        float amountToMoveY = transform.position.y - lastYPos;
	   
	    farBackground.position = farBackground.position + new Vector3(amountToMoveX, amountToMoveY, 0f);
	    middleBackground.position += new Vector3(amountToMoveX * .5f, amountToMoveY * .5f, 0f);
	   
	    lastXPos = transform.position.x;
        lastYPos = transform.position.y;
    }
}
