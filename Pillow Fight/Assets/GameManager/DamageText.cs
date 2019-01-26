using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageText : MonoBehaviour
{
    
    
    void Update()
    {
        Vector3 pos = transform.position;
        pos.y += 1 * Time.deltaTime;
        transform.position = pos;
    }
}
