﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public Player p;
    public Sprite icon;
    public string pName;
    

    public List<GameObject> skillObj = new List<GameObject>();

    public void Start()
    {
        p = GetComponent<Player>();
    }

    public void Update()
    {
        if (p.health <= 0) return;

        if (Input.GetButtonDown("TriggerLeft" + p.playerNumber))
        {
            if(p.energy >= 10)
            {
                p.energy = 1;
                Special();
            }
        }
        
        if (Input.GetButtonDown("TriggerRight" + p.playerNumber))
        {           
            Shoot();
        }

    }

    public void Shoot()
    {
        
        GameObject obj = Instantiate(skillObj[0], p.spawn.position, Quaternion.identity);
        Projectile proj = obj.GetComponent<Projectile>();
        proj.pN = p.playerNumber;
        proj.Shoot(transform.rotation, 825);
        proj.attack = 10;
        FMODUnity.RuntimeManager.PlayOneShot(FMODPaths.THROW_SFX, GetComponent<Transform>().position);

        p.anim.SetTrigger("Attacks");
    }

    public void Special()
    {
        if(pName == "Pedda")
        {
            GameObject obj = Instantiate(skillObj[1], p.spawn.position, Quaternion.identity);
            Tornado tor = obj.GetComponent<Tornado>();
            tor.transform.rotation = transform.rotation;

            p.anim.SetTrigger("Attacks");
        }
        else if(pName == "Ted Shredder")
        {
            GameObject obj = Instantiate(skillObj[1], p.spawn.position, Quaternion.identity);
            Shockwave tor = obj.GetComponent<Shockwave>();
            tor.transform.rotation = transform.rotation;

            p.anim.SetTrigger("Attacks");
        }
        else if (pName == "Pompf")
        {
            GameObject obj = Instantiate(skillObj[1], transform.position, Quaternion.identity);
            

            p.anim.SetTrigger("Attacks");
        }
        else if (pName == "Justin")
        {
            if(skillObj[1].activeSelf == false)
            {
                skillObj[1].SetActive(true);
                skillObj[1].GetComponent<DivineShield>().lifeTime = 5;
            }
           
            p.anim.SetTrigger("Attacks");
        }

    }
}
