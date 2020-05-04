using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    void ExplosionDamage()
    {
        Vector3 center = transform.position;
        float radius = 15f;

        Collider[] hitColliders = Physics.OverlapSphere(center, radius);
        int i = 0;
        while (i < hitColliders.Length)
        {
            hitColliders[i].SendMessage("AddDamage");
            i++;
        }
    }
}
