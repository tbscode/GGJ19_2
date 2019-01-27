using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class InterSceneManager : MonoBehaviour
{
    public static InterSceneManager iSM;
    public MainMenu mM;
    public GameObject optionsPanel;
    public int optionsInt;
    public float optionsCounter;

    public List<PlayerStats> pS = new List<PlayerStats>();
    public List<TextMeshProUGUI> txtList = new List<TextMeshProUGUI>();
    public Color tColor;
    public Color selectColor;

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

        tColor = txtList[0].color;
    }

    public void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            Debug.Log("Hallo!");
            if(optionsPanel.activeSelf == false)
            {
                optionsPanel.SetActive(true);
                optionsInt = 0;
                UpdateOptions();
            }
            else
            {
                optionsPanel.SetActive(false);
            }


        }

        if (optionsPanel.activeSelf == true)
        {
            

            float y = Input.GetAxis("VerticalLeft" + 1);

            if(optionsCounter <= 0 && y != 0)
            {
                optionsCounter = 0.33f;
                if(y < 0)
                {
                    optionsInt += 1;
                    if(optionsInt > 2)
                    {
                        optionsInt = 0;
                    }
                }
                else if (y > 0)
                {
                    optionsInt -= 1;
                    if (optionsInt < 0)
                    {
                        optionsInt = 2;
                    }
                }
                UpdateOptions();
            }



            if (Input.GetButtonDown("TriggerRight" + 1))
            {
                if (optionsInt == 0)
                {
                    optionsPanel.SetActive(false);
                }
                else if (optionsInt == 1)
                {
                    EndFight();
                }
                else if (optionsInt == 2)
                {
                    Application.Quit();
                }
            }

            if (Input.GetButtonDown("TriggerLeft" + 1))
            {
                optionsPanel.SetActive(false);
            }

        }

        if(optionsCounter > 0)
        {
            optionsCounter -= 1 * Time.deltaTime;

        }

        

    }

    public void UpdateOptions()
    {
        foreach(TextMeshProUGUI t in txtList)
        {
            t.color = tColor;
        }

        txtList[optionsInt].color = selectColor;
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
        mM.StartKulisse.SetActive(true);
        mM.SelectKulisse.SetActive(false);

        AudioManager.instance.SetParameterInt(AudioManager.instance.music, "Transition", 0);
        AudioManager.instance.SetParameterInt(AudioManager.instance.music, "Vocals", 0);
        AudioManager.instance.SetParameterInt(AudioManager.instance.music, "SpielEnde", 0);

        optionsPanel.SetActive(false);
    }
}
