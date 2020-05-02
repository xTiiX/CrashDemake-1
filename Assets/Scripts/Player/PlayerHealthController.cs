using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
	
	public static PlayerHealthController instance;
	
	public int currentHealth, maxHealth;
	
	public float invincibleLength;
	
	private float invincibleCounter;
	
	private SpriteRenderer theSR;

    public GameObject AkuAku;
    public bool isAttack = false;
	
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
		if(invincibleCounter <=0 && AkuAku.gameObject.activeInHierarchy == false)
		{
			//currentHealth -= 1;
			currentHealth--;
			
			if(currentHealth <= 0)
			{
				currentHealth = 0;
				
				gameObject.SetActive(false);
			} else
			{
				invincibleCounter = invincibleLength;
				
				theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, .5f);
				
				PlayerController.instance.knockBack();
			}
			
			UIController.instance.UpdateHealthDisplay();
		}
        if (AkuAku.gameObject.activeInHierarchy)
        {
            isAttack = true;
        }
	}
}
