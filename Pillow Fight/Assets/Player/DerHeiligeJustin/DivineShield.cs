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
}
