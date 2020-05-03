using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBounceController : MonoBehaviour
{
    public GameObject wumpa;
    public Vector3 boxPos;

    private int numberOfWumpa = 9;

    public void Start()
    {
        boxPos = new Vector3(transform.position.x, transform.position.y + 5, transform.position.z);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var normal = collision.contacts[0].normal;
        if (normal.y < 0)
        {
            PlayerController.instance.boxJumped();
            if (numberOfWumpa > 0)
            {
                Instantiate(wumpa, boxPos, new Quaternion(0, 0, 0, 0), transform);
                numberOfWumpa--;
            }
            else
            {
                Instantiate(wumpa, boxPos, new Quaternion(0, 0, 0, 0), transform);
                Destroy(gameObject);
            }
        }
    }
}
