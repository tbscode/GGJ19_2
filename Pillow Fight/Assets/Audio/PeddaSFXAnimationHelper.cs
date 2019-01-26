using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeddaSFXAnimationHelper : MonoBehaviour
{
    public void PeddaFoosteps()
    {
        FMODUnity.RuntimeManager.PlayOneShot(FMODPaths.FOOTSTEPS_PEDDA, GetComponent<Transform>().position);
    }
}
