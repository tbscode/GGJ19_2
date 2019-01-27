using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivineShield : MonoBehaviour
{
    public float lifeTime;

    void Update()
    {
        if(gameObject.activeSelf == true)
        {
            if (lifeTime > 0)
            {
                lifeTime -= 1 * Time.deltaTime;

            }
            else
            {
                gameObject.SetActive(false);
            }
        }

        
    }

    public void OnTriggerEnter(Collider other)
    {
        

        if (other.transform.tag == "Pillow")
        {
            Debug.Log("Pillow!!!");

            float power = 2000;

            Vector3 colPos = other.transform.position;
            Vector3 pos = transform.position;

            Vector3 direction = colPos - pos;

            other.gameObject.GetComponent<Rigidbody>().AddForce(direction * power);
        }
    }
}
