using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyOrb : MonoBehaviour
{
    public GameObject deathEffect;
    public GameObject spawnEffect;

    public void Start()
    {
        GameObject obj = Instantiate(spawnEffect, transform.position, Quaternion.identity);
        Destroy(obj, 1f);
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            Player p = other.gameObject.GetComponent<Player>();

            int heal = Random.Range(5, 15);
            p.energy += heal;

            if(p.energy > 100)
            {
                p.energy = 100;
            }

            GameObject obj = Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(obj, 1f);
            Destroy(gameObject);
        }
    }
}
