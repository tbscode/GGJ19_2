using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nova : MonoBehaviour
{
    public Rigidbody rb;
    public float lifeTime;
    public SphereCollider col;

    void Start()
    {
        
        
    }

    
    void Update()
    {
        col.radius += 15 * Time.deltaTime;

        if (lifeTime > 0)
        {
            lifeTime -= 1 * Time.deltaTime;

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
