using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSettings : MonoBehaviour
{
    [Range(0.0f, 1.0f)]
    public float musicVolume = 1f;
    [Range(0.0f, 1.0f)]
    public float sfxVolume = 1f;

    void Update()
    {
        FMODUnity.RuntimeManager.GetVCA(FMODPaths.VCA_MUSIC).setVolume(musicVolume); // Float value von 0 - 1f
        FMODUnity.RuntimeManager.GetVCA(FMODPaths.VCA_SFX).setVolume(sfxVolume); // Float value von 0 - 1f
    }
}
