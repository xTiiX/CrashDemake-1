using UnityEngine;

public class AkuAkuController : MonoBehaviour
{
    public static AkuAkuController instance;

    public GameObject target;

    public float smoothSpeed = 15f;
    public Vector3 offset;

    private int left = 2;
    private int right = -2;

    public int lives = 3;

    private void Awake()
    {
        instance = this;    
    }

    private void Start()
    {
        gameObject.transform.localScale = new Vector3(0.8f, 0.8f, 0);
    }

    private void FixedUpdate()
    {
        if (lives == 3)
        {
            gameObject.transform.localScale = new Vector3(0.8f, 0.8f, 0);
        } else if (lives == 2)
        {
            gameObject.transform.localScale = new Vector3(0.6f, 0.6f, 0);
        } else if (lives == 1)
        {
            gameObject.transform.localScale = new Vector3(0.4f, 0.4f, 0);
        }
    }

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
            if (target.GetComponent<PlayerHealthController>().isAttacked)
            {
                if (lives == 3)
                {
                    //3 lives 
                    lives--;

                    //Change the sprite
                    target.GetComponent<PlayerHealthController>().isAttacked = false;
                }
                else if (lives == 2)
                {
                    //2 lives
                    lives--;

                    //Change the sprite
                    target.GetComponent<PlayerHealthController>().isAttacked = false;
                }
                else if (lives == 1)
                {
                    //1 life
                    lives--;

                    //Change the sprite
                    target.GetComponent<PlayerHealthController>().isAttacked = false;
                }
            }

        }

    }

    public void NewAkuAku()
    {
        if (lives == 0)
        {
            gameObject.SetActive(true);
        }

        lives = 3;
    }
}