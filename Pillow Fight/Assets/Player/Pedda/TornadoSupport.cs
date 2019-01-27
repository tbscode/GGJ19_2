using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoSupport : MonoBehaviour
{
    Collider col;


    void Start()
    {
        col = GetComponent<Collider>();
    }

    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag != "Pillow")
        {
            Physics.IgnoreCollision(collision.collider, col);
        }

    }
}
