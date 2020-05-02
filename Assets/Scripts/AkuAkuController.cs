using UnityEngine;

public class AkuAkuController : MonoBehaviour
{
    public GameObject target;

    public float smoothSpeed = 15f;
    public Vector3 offset;

    private int left = 2;
    private int right = -2;

    private int lives = 3;

    private void LateUpdate()
    {
        if (gameObject.activeInHierarchy)
        {
            //Player's direction
            //Change Sprite Direction
            if (target.GetComponent<PlayerController>().theSR.flipX)
            {
                offset = new Vector3(left, offset.y, offset.z);
                transform.rotation = new Quaternion(0, 0, 0, 0);
            }
            else
            {
                offset = new Vector3(right, offset.y, offset.z);
                transform.rotation = new Quaternion(0, 180, 0, 0);

            }

            //Set the new position
            Vector3 finalPos = target.transform.position + offset;
            Vector3 smoothPos = Vector3.Lerp(transform.position, finalPos, smoothSpeed * Time.deltaTime);

            transform.position = smoothPos;
            
            if (lives <= 0)
            {
                //Dead
                gameObject.SetActive(false);
            }

            //Shield
            if (target.GetComponent<PlayerHealthController>().isAttack)
            {
                if (lives == 3)
                {
                    //3 lives 


                }
                else if (lives == 2)
                {
                    //2 lives


                }
                else if (lives == 1)
                {
                    //1 life


                }
            }

        }

    }
}