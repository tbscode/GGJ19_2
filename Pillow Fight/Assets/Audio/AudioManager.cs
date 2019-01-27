using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance = null;
    public FMOD.Studio.EventInstance music;
    public FMOD.Studio.EventInstance ambient;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;

            //Je nach dem ob wir mehr scenes haben
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

    }

    public void MusicStart()
    {

        FMOD.Studio.PLAYBACK_STATE _music;
        music.getPlaybackState(out _music);
        if (_music != FMOD.Studio.PLAYBACK_STATE.PLAYING)
        {
            music = FMODUnity.RuntimeManager.CreateInstance(FMODPaths.MUSIC);
            music = FMODUnity.RuntimeManager.CreateInstance(FMODPaths.AMBIENT);
            music.start();
            ambient.start();
        }
    }



    public void MusicStop()
    {
        FMOD.Studio.Bus musicBus = FMODUnity.RuntimeManager.GetBus("bus:/Master/Music");
        musicBus.stopAllEvents(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }

    public void MusicStopImmediate()
    {
        FMOD.Studio.Bus musicBus = FMODUnity.RuntimeManager.GetBus("bus:/Master/Music");
        musicBus.stopAllEvents(FMOD.Studio.STOP_MODE.IMMEDIATE);
    }

    public void SetParameterInt(FMOD.Studio.EventInstance instance, string parameter, int value)
    {
        FMOD.Studio.ParameterInstance _parameter;
        instance.getParameter(parameter, out _parameter);

        _parameter.setValue(value);
    }

    public void SetParameterFloat(FMOD.Studio.EventInstance instance, string parameter, float value)
    {
        FMOD.Studio.ParameterInstance _parameter;
        instance.getParameter(parameter, out _parameter);

        _parameter.setValue(value);
    }
}
