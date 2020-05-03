using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject target;
    
    private float positionY;
    private float oldPosY;


	public Transform farBackground, middleBackground;
	
	private float lastXPos;
    

    void Start()
    {
        lastXPos = transform.position.x;
        oldPosY = transform.position.y;
    }

    void Update()
    {

        //print(target.GetComponent<PlayerController>().isJumped);
        if (target.GetComponent<PlayerController>().isJumped)
        {
            positionY = target.transform.position.y;
        } else
        {
            positionY = oldPosY;
        }

       transform.position = new Vector3(target.transform.position.x, transform.position.y, transform.position.z); 
	   
	   float amountToMoveX = transform.position.x - lastXPos;
	   
	   farBackground.position = farBackground.position + new Vector3(amountToMoveX, 0f, 0f);
	   middleBackground.position += new Vector3(amountToMoveX * .5f, 0f, 0f);
	   
	   lastXPos = transform.position.x;

    }
}
