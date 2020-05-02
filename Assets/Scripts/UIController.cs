using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
	public static UIController instance;
	
	public Image crashlive1, crashlive2, crashlive3;
	
	public Sprite crashFull, crashEmpty;
	
	private void Awake()
	{
		instance = this;
	}
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void UpdateHealthDisplay()
	{
		switch(PlayerHealthController.instance.currentHealth)
		{
			case 3:
				crashlive1.sprite = crashFull;
				crashlive2.sprite = crashFull;
				crashlive3.sprite = crashFull;
				
				break;
				
			case 2:
				crashlive1.sprite = crashFull;
				crashlive2.sprite = crashFull;
				crashlive3.sprite = crashEmpty;
				
				break;
			
			case 1:
				crashlive1.sprite = crashFull;
				crashlive2.sprite = crashEmpty;
				crashlive3.sprite = crashEmpty;
				
				break;
				
			case 0:
				crashlive1.sprite = crashEmpty;
				crashlive2.sprite = crashEmpty;
				crashlive3.sprite = crashEmpty;
				
				break;
				
			default:
				crashlive1.sprite = crashEmpty;
				crashlive2.sprite = crashEmpty;
				crashlive3.sprite = crashEmpty;
				
				break;
		}
	}
}
