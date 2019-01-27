using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TedSFXAnimationHelper : MonoBehaviour
{
    public void TedFoosteps()
    {
        FMODUnity.RuntimeManager.PlayOneShot(FMODPaths.FOOTSTEPS_TED, GetComponent<Transform>().position);
    }

    public void TedAttack()
    {
        float randValue = Random.value;

        if (randValue < .45f)
        {
            FMODUnity.RuntimeManager.PlayOneShot(FMODPaths.TED_ATTACK, GetComponent<Transform>().position);
        }
    }
}
