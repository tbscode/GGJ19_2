﻿using System.Collections;
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
    }

    public void Update()
    {
        

        
    }

    public void StartFight()
    {
        SceneManager.LoadScene("SampleScene");

        mM.StartPan.SetActive(false);
        mM.SelectPan.SetActive(false);


    }
}
