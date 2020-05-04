﻿using UnityEngine;
using System.Collections;

public class BoxTNTController : MonoBehaviour
{
    public static BoxTNTController instance;
    public bool isExplose = false;


    private void Awake()
    {
        instance = this;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            var normal = collision.contacts[0].normal;
            if (normal.y < 0)
            {
                StartCoroutine(explosion());
            } else if (PlayerController.instance.isInAttack)
            {
                isExplose = true;
            }
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (PlayerController.instance.isInAttack)
            {
                isExplose = true;
            }
        }
    }

    IEnumerator explosion()
    {
        yield return new WaitForSeconds(3f);
        isExplose = true;
    }
}