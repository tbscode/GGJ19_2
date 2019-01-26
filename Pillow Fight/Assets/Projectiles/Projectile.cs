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
    private FMOD.Studio.EventInstance wallImpactSFX;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        groundImpactSFX = FMODUnity.RuntimeManager.CreateInstance(FMODPaths.GROUND_IMPACT);
        wallImpactSFX = FMODUnity.RuntimeManager.CreateInstance(FMODPaths.WALL_IMPACT);
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
                Debug.Log(impact);
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

        if (col.gameObject.name == "Wall" || col.gameObject.name == "Wall (1)" || col.gameObject.name == "Wall (2)" || col.gameObject.name == "Wall (3)")
        {
            wallImpactSFX.setParameterValue("force", impact);
            wallImpactSFX.start();
            FMODUnity.RuntimeManager.AttachInstanceToGameObject(wallImpactSFX, GetComponent<Transform>(), GetComponent<Rigidbody>());
            wallImpactSFX.release();
        }

    }

    public void Damage(int damage, Vector3 pos, Player player)
    {
        

        
    }
}
