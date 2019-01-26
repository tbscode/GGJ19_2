using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectMenu : MonoBehaviour
{
    public List<GameObject> charSelectBtn = new List<GameObject>();
    public InterSceneManager iSM;

    public void UpdateMenu()
    {
        iSM = GameObject.Find("InterSceneManager").GetComponent<InterSceneManager>();

        foreach(GameObject cS in charSelectBtn)
        {
            cS.GetComponent<SelectPan>().UpdateThis();
        }
    }
}
