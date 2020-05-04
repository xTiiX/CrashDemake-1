using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenu : MonoBehaviour
{
	public string restartScene;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void RestartGame()
	{
		SceneManager.LoadScene(restartScene);
	}
	
	public void QuitGame()
	{
		Application.Quit();
		
		Debug.Log("Quitting Game");
	}
}
