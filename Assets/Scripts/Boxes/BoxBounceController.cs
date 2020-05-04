using System.Collections;
using UnityEngine;

public class BoxBounceController : MonoBehaviour
{
    public GameObject wumpa;
    public Vector3 boxPos;

    private int numberOfWumpa = 10;

    public void Start()
    {
        boxPos = new Vector3(transform.position.x, transform.position.y + 5, transform.position.z);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var normal = collision.contacts[0].normal;
        if (normal.y < 0)
        {
            if (numberOfWumpa < 1)
            {
                StartCoroutine(BoxBounceDestroy());
                gameObject.SetActive(false);
            }
            else
            {
                PlayerController.instance.boxJumped();
                Instantiate(wumpa, boxPos, new Quaternion(0, 0, 0, 0), transform);
            }
            numberOfWumpa--;
        }
    }

    IEnumerator BoxBounceDestroy()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
