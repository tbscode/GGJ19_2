using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeddaSFXAnimationHelper : MonoBehaviour
{
    public void PeddaFoosteps()
    {
        FMODUnity.RuntimeManager.PlayOneShot(FMODPaths.FOOTSTEPS_PEDDA, GetComponent<Transform>().position);
    }

    public void PeddaAttack()
    {
        float randValue = Random.value;

        if (randValue < .45f) 
        {
            FMODUnity.RuntimeManager.PlayOneShot(FMODPaths.PEDDA_ATTACK, GetComponent<Transform>().position);
        }
    }
   
}
