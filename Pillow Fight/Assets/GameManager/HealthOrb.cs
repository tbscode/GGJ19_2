using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthOrb : MonoBehaviour
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
        if (other.transform.tag == "Player")
        {
            Player p = other.gameObject.GetComponent<Player>();

            int heal = Random.Range(5, 25);
            p.health += heal;

            if (p.health > 200)
            {
                p.health = 200;
            }

            GameObject obj = Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(obj, 1f);
            Destroy(gameObject);
        }
    }
}
