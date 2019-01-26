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
        if (mM.SelectPan.activeSelf == true)
        {
            if(counter <= 0)
            {
                counter = 1f;

                float x = Input.GetAxis("HorizontalLeft" + playerNumber);

                if (x > 0)
                {
                    Debug.Log("Hallo");

                    pIndex++;
                    if (pIndex >= mM.SelectPan.GetComponent<SelectMenu>().charSelectBtn.Count)
                    {
                        pIndex = 0;
                    }
                }
            }
            else
            {
                counter -= 1 * Time.deltaTime;
            }
            
            

            if (Input.GetButtonDown("TriggerRight" + playerNumber))
            {

            }

            mM.SelectPan.GetComponent<SelectMenu>().UpdateMenu();
        }

        
        
    }
}
