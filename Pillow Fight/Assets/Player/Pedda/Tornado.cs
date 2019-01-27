using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tornado : MonoBehaviour
{
    public GameObject TornadoCol;
    public float speed;
    public float moveSpeed;
    public float lifeTime;

    void Update()
    {
        TornadoCol.transform.Rotate(Vector3.right * Time.deltaTime * speed);

        transform.Translate(Vector3.forward * Time.deltaTime);

        if(lifeTime > 0)
        {
            lifeTime -= 1 * Time.deltaTime;

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
