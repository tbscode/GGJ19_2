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
        else
        {
            float power = 5000;

            Vector3 colPos = col.transform.position;
            Vector3 pos = transform.position;

            Vector3 direction = colPos - pos;

            col.gameObject.GetComponent<Rigidbody>().AddForce(direction * power);
        }

    }
}
