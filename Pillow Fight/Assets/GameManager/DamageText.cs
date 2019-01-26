using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageText : MonoBehaviour
{
    public float velo;
    
    void Update()
    {
        Vector3 pos = transform.position;
        pos.y += velo * Time.deltaTime;
        transform.position = pos;
    }
}
