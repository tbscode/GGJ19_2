using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectMenu : MonoBehaviour
{
    public List<GameObject> charSelectBtn = new List<GameObject>();
    public InterSceneManager iSM;
    public bool countDown;
    public float counter;

    public void UpdateMenu()
    {
        iSM = GameObject.Find("InterSceneManager").GetComponent<InterSceneManager>();

        foreach(GameObject cS in charSelectBtn)
        {
            cS.GetComponent<SelectPan>().UpdateThis();

            
        }

        bool startGame = true;

        foreach(PlayerStats pS in iSM.pS)
        {
            if(pS.pPrefab == null)
            {
                startGame = false;
            }
        }

        if(startGame == true)
        {
            countDown = true;
            counter = 3;
        }
        else
        {
            if(countDown == true)
            {
                countDown = false;
            }
        }
    }

    public void Update()
    {
        if(countDown == true)
        {
            if(counter > 0)
            {
                counter -= 1 * Time.deltaTime;
            }
            else
            {
                countDown = false;
                iSM.StartFight();
            }
        }
        else if(counter > 0)
        {
            counter = 0;
        }
    }
}
