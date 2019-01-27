using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterSceneManager : MonoBehaviour
{
    public static InterSceneManager iSM;
    public MainMenu mM;

    public List<PlayerStats> pS = new List<PlayerStats>();

    public void Start()
    {
       DontDestroyOnLoad(gameObject);
       if(iSM == null)
        {
            iSM = this;
        }
       else
        {
            Destroy(gameObject);
        }

        mM = GameObject.Find("MainMenu").GetComponent<MainMenu>();
        AudioManager.instance.MusicStart();
    }

    public void Update()
    {
        

        
    }

    public void StartFight()
    {
        SceneManager.LoadScene("SampleScene");

        mM.StartPan.SetActive(false);
        mM.SelectPan.SetActive(false);

        AudioManager.instance.SetParameterInt(AudioManager.instance.music, "Transition", 1);


    }

    public void EndFight()
    {
        SceneManager.LoadScene("MainMenu");

        mM.StartPan.SetActive(true);
        mM.SelectPan.SetActive(false);

        AudioManager.instance.SetParameterInt(AudioManager.instance.music, "Transition", 0);
        AudioManager.instance.SetParameterInt(AudioManager.instance.music, "Vocals", 0);
        AudioManager.instance.SetParameterInt(AudioManager.instance.music, "SpielEnde", 0);
    }
}
