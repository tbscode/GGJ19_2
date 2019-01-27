using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody rb;
    public int pN;
    public float currentSpeed;
    public float attack;
    private FMOD.Studio.EventInstance groundImpactSFX;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        groundImpactSFX = FMODUnity.RuntimeManager.CreateInstance(FMODPaths.GROUND_IMPACT); 
    }

    public void Shoot(Quaternion rot, float power)
    {
        transform.rotation = rot;
        rb.AddForce(transform.forward * power);
    }

    void OnCollisionEnter(Collision col)
    {
        

        float impact = col.relativeVelocity.magnitude;

        if (impact > 10)
        {
            if (col.gameObject.transform.tag == "Player")
            {
                
                int damage = Mathf.RoundToInt(impact);
                Player player = col.gameObject.GetComponent<Player>();

                player.Damage(damage, col.transform.position);
                
            }
         
        }

        if (col.gameObject.name == "Ground")
        {
            groundImpactSFX.setParameterValue("force", impact);
            groundImpactSFX.start();
            FMODUnity.RuntimeManager.AttachInstanceToGameObject(groundImpactSFX, GetComponent<Transform>(), GetComponent<Rigidbody>());
            groundImpactSFX.release();
        }

    }

    public void Damage(int damage, Vector3 pos, Player player)
    {
        

        
    }
}
