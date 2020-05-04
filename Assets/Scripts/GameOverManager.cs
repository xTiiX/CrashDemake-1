using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverManager : MonoBehaviour
{
	public string gameoverScreen;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHealthController.instance.currentHealth == 0)
		{
			SceneManager.LoadScene(gameoverScreen);
		} 
    }
}
