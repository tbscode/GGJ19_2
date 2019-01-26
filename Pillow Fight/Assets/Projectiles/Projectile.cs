using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody rb;
    public int pN;
    public float currentSpeed;
    public float attack;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Shoot(Quaternion rot, float power)
    {
        transform.rotation = rot;
        rb.AddForce(transform.forward * power);
    }

    void OnCollisionEnter(Collision col)
    {
        

        float impact = col.relativeVelocity.magnitude;
        
        if (impact > 5)
        {
            if (col.gameObject.transform.tag == "Player")
            {
                Debug.Log(impact);
                int damage = Mathf.RoundToInt(impact);
                Player player = col.gameObject.GetComponent<Player>();

                player.Damage(damage, col.transform.position);
                
            }

            
        }
            
    }

    public void Damage(int damage, Vector3 pos, Player player)
    {
        

        
    }
}
