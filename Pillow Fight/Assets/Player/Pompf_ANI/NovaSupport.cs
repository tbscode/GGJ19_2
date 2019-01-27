using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NovaSupport : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "Pillow")
        {
            float power = 500;

            Vector3 colPos = col.transform.position;
            Vector3 pos = transform.position;

            Vector3 direction = colPos - pos;

            col.gameObject.GetComponent<Rigidbody>().AddForce(direction * power);
        }

    }
}
