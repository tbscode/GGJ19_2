using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject StartPan;
    public GameObject SelectPan;

    public InterSceneManager iSM;

    void Update()
    {
        if(StartPan.activeSelf == true)
        {
            if(Input.anyKey == true)
            {
                StartPan.SetActive(false);
                SelectPan.SetActive(true);
            }
        }
        else if(SelectPan.activeSelf == true)
        {
            iSM = GameObject.Find("InterSceneManager").GetComponent<InterSceneManager>();
            
            foreach(PlayerStats pS in iSM.pS)
            {
                pS.pIndex = 0;
                pS.pPrefab = null;
            }

            SelectPan.GetComponent<SelectMenu>().UpdateMenu();
                
        }
    }
}
