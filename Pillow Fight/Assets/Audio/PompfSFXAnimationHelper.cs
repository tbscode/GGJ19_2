using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PompfSFXAnimationHelper : MonoBehaviour
{
    public void PompfSFXFoosteps()
    {
        FMODUnity.RuntimeManager.PlayOneShot(FMODPaths.FOOTSTEPS_POMPF, GetComponent<Transform>().position);
    }

    public void PompfSFXAttack()
    {
        float randValue = Random.value;

        if (randValue < .45f)
        {
            FMODUnity.RuntimeManager.PlayOneShot(FMODPaths.POMPF_ATTACK, GetComponent<Transform>().position);
        }
    }
}
