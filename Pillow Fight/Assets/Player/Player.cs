using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    public Vector3 vec;
    public Quaternion rot;
    public Vector3 fighterPos;
    public int playerNumber;
    public Transform spawn;
    public GameObject picture;

    public Animator anim;
    public GameManager gm;

    public float health = 200;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = picture.GetComponent<Animator>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        fighterPos = transform.position;

        Move();
        Rotate();
    }


    public void Move()
    {
        float y = Input.GetAxis("VerticalLeft" + playerNumber);
        float x = Input.GetAxis("HorizontalLeft" + playerNumber);

        vec.z = x;
        vec.x = -y;


        if (speed > 0)
        {
            rb.velocity = vec * speed;
            transform.position = fighterPos;          

        }
        

        if(y != 0|| x != 0)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
    }

    public void Rotate()
    {

        float y = Input.GetAxis("VerticalRight" + playerNumber);
        float x = Input.GetAxis("HorizontalRight" + playerNumber);

        if(y != 0 || x != 0)
        {

        }
        else
        {
            return;
        }

        var angle = Mathf.Atan2(y, x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, -angle, 0);
        
        //==========================

        if(x >= 0)
        {
            Quaternion facing = Quaternion.Euler(0, 270, 0);

            picture.transform.rotation = facing;
        }
        else if(x < 0)
        {
            Quaternion facing = Quaternion.Euler(0, 90, 0);

            picture.transform.rotation = facing;
        }

    }

    public void Damage(int damage, Vector3 pos)
    {
        if(health > 0)
        {
            
            gm.DamageText(pos, damage);

            anim.SetTrigger("isHit");
            health -= damage;

            if (health <= 0)
            {
                Death();
            }
        }

        
    }

    public void Death()
    {
        anim.SetTrigger("Dies");
    }
}
