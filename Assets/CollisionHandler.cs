using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D o)
    {

        if (o.tag == "particle")
        {
            Destroy(o.gameObject);
        }
    }
}
