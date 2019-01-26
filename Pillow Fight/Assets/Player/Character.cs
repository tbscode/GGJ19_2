using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Player p;

    public List<GameObject> skillObj = new List<GameObject>();

    public void Start()
    {
        p = GetComponent<Player>();
    }

    public void Update()
    {
        if (Input.GetButtonDown("TriggerLeft" + p.playerNumber))
        {
            Debug.Log("Button Left");
        }
        
        if (Input.GetButtonDown("TriggerRight" + p.playerNumber))
        {           
            Shoot();
        }

    }

    public void Shoot()
    {
        Debug.Log("Button Right");
        GameObject obj = Instantiate(skillObj[0], p.spawn.position, Quaternion.identity);
        Projectile proj = obj.GetComponent<Projectile>();
        proj.pN = p.playerNumber;
        proj.Shoot(transform.rotation, 1000);
        proj.attack = 10;

        p.anim.SetTrigger("Attacks");
    }
}
