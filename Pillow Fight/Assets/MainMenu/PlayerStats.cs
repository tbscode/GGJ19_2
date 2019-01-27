using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerStats : MonoBehaviour
{
    public int playerNumber;
    public GameObject pPrefab;
    public Color pColor;
    public int pIndex;
    public MainMenu mM;
    public int selectInd;

    public float counter;

    public void Start()
    {
        mM = GameObject.Find("MainMenu").GetComponent<MainMenu>();

    }

    public void Update()
    {
        

        mM = GameObject.Find("MainMenu").GetComponent<MainMenu>();

        if (mM.SelectPan.activeSelf == true)
        {
            float x = Input.GetAxis("HorizontalLeft" + playerNumber);

            if(pPrefab == null)
            {
                if (counter <= 0)
                {
                    if (x > 0)
                    {
                        counter = 0.25f;
                        

                        pIndex += 1;
                        if (pIndex >= mM.SelectPan.GetComponent<SelectMenu>().charSelectBtn.Count)
                        {
                            pIndex = 0;
                        }

                        mM.SelectPan.GetComponent<SelectMenu>().UpdateMenu();
                    }
                    else if (x < 0)
                    {
                        counter = 0.25f;
                        

                        pIndex -= 1;
                        if (pIndex < 0)
                        {
                            pIndex = mM.SelectPan.GetComponent<SelectMenu>().charSelectBtn.Count - 1;
                        }

                        mM.SelectPan.GetComponent<SelectMenu>().UpdateMenu();
                    }
                }
                else
                {
                    counter -= 1 * Time.deltaTime;
                }

                if (Input.GetButtonDown("TriggerRight" + playerNumber))
                {
                    pPrefab = mM.SelectPan.GetComponent<SelectMenu>().charSelectBtn[pIndex].GetComponent<SelectPan>().chara;
                    mM.SelectPan.GetComponent<SelectMenu>().UpdateMenu();


                }
            }
            else
            {
                if (Input.GetButtonDown("TriggerLeft" + playerNumber))
                {
                    pPrefab = null;
                    mM.SelectPan.GetComponent<SelectMenu>().UpdateMenu();
                }
            }


            
        }



    }


        
    
}
