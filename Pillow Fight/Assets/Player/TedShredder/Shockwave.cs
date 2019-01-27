using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shockwave : MonoBehaviour
{
    public float speed;
    public float moveSpeed;
    public float lifeTime;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);

        if (lifeTime > 0)
        {
            lifeTime -= 1 * Time.deltaTime;

        }
        else
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.transform.tag =="Pillow")
        {
            float power = 5000;

            Vector3 colPos = col.transform.position;
            Vector3 pos = transform.position;

            Vector3 direction = colPos - pos;

            col.gameObject.GetComponent<Rigidbody>().AddForce(direction * power);
        }
      

    }
}
