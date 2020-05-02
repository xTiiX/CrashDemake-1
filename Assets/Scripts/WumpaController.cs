using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WumpaController : MonoBehaviour
{
    public int value = 1;

    private GameObject UI;

    // Start is called before the first frame update
    void Start()
    {
        UI = GameObject.FindGameObjectWithTag("WumpaAmount");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            int wumpaUI = int.Parse(UI.GetComponent<Text>().text) + value;
            UI.GetComponent<Text>().text = wumpaUI + "";
            Destroy(gameObject);
        }
    }
}
