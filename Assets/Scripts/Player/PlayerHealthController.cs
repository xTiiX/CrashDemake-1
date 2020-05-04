using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
	
	public static PlayerHealthController instance;
	
	public int currentHealth, maxHealth;
	
	public float invincibleLength;
	
	private float invincibleCounter;
	
	private SpriteRenderer theSR;

    public GameObject AkuAku;
    public bool isAttacked = false;
	
	private void Awake()
	{
		instance = this;
	}
	
    void Start()
    {
        currentHealth = maxHealth;
	
		theSR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (invincibleCounter > 0)
		{
			invincibleCounter -= Time.deltaTime;
			
			if(invincibleCounter <= 0)
			{
				theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, 1f);
			}
		}
    }

	public void DealDamage()
	{
		if (AkuAku.gameObject.activeInHierarchy == false)
		{
			//currentHealth -= 1;
			currentHealth--;

			LevelManager.instance.RespawnPlayer();

			if (currentHealth <= 0)
			{
				currentHealth = 0;
				print("you are dead");

				//gameObject.SetActive(false);
			}

			UIController.instance.UpdateHealthDisplay();
            GetComponent<PlayerController>().isInAttack = false;
        }

		if (AkuAku.gameObject.activeInHierarchy)
		{
			invincibleCounter = invincibleLength;

			theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, .5f);
			isAttacked = true;
			PlayerController.instance.knockBack();
		}
	}

    public void explosion()
    {
        //currentHealth -= 1;
        currentHealth--;

        LevelManager.instance.RespawnPlayer();

        if (currentHealth <= 0)
        {
            currentHealth = 0;
        }

        if (AkuAku.gameObject.activeInHierarchy)
        {
			AkuAkuController.instance.lives = 0;
        }

        UIController.instance.UpdateHealthDisplay();
        PlayerController.instance.isInAttack = false;
    }

	public void WinLife()
    {
		currentHealth++;
		UIController.instance.UpdateHealthDisplay();
	}
}
