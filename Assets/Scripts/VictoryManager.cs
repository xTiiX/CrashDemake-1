using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class VictoryManager : MonoBehaviour
{
	public static VictoryManager instance;
	public string victoryScreen;
	
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
	
	public void ReturnScene()
	{
		SceneManager.LoadScene(victoryScreen);
	}
}
