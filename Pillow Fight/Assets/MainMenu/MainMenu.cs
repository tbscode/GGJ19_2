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
        iSM = GameObject.Find("InterSceneManager").GetComponent<InterSceneManager>();

        if (StartPan.activeSelf == true)
        {
            if(Input.anyKey == true)
            {
                StartPan.SetActive(false);
                SelectPan.SetActive(true);

                foreach (PlayerStats pS in iSM.pS)
                {
                    pS.pIndex = 0;
                    pS.pPrefab = null;
                }

                SelectPan.GetComponent<SelectMenu>().UpdateMenu();
            }
        }
        else if(SelectPan.activeSelf == true)
        {
            
            
            
                
        }
    }
}
