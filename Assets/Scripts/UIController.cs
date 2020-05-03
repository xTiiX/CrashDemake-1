using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
	
    public static UIController instance;
    private GameObject UI;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UI = GameObject.FindGameObjectWithTag("LifeAmount");
        UI.GetComponent<Text>().text = PlayerHealthController.instance.maxHealth + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHealthDisplay()
    {
        UI.GetComponent<Text>().text = PlayerHealthController.instance.currentHealth + "";
    }
}
