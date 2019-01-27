using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustinSFXAnimationHelper : MonoBehaviour
{
    public void JustinFoosteps()
    {
        FMODUnity.RuntimeManager.PlayOneShot(FMODPaths.FOOTSTEPS_JUSTIN, GetComponent<Transform>().position);
    }

    public void JustinAttack()
    {
        float randValue = Random.value;

        if (randValue < .45f)
        {
            FMODUnity.RuntimeManager.PlayOneShot(FMODPaths.JUSTIN_ATTACK, GetComponent<Transform>().position);
        }
    }
}
