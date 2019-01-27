using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectPan : MonoBehaviour
{
    public int index;
    public GameObject chara;
    public Image img;

    public InterSceneManager iSM;
    public List<GameObject> selectIcon = new List<GameObject>();

    public Animator anim;

    void Start()
    {
        
    }

    public void UpdateThis()
    {
        img = GetComponent<Image>();

        iSM = GameObject.Find("InterSceneManager").GetComponent<InterSceneManager>();

        img.sprite = chara.GetComponent<Character>().icon;

        foreach (PlayerStats pS in iSM.pS)
        {
            selectIcon[pS.playerNumber - 1].GetComponent<Image>().color = pS.pColor;
            if (pS.pIndex == index)
            {
                selectIcon[pS.playerNumber-1].SetActive(true);
                
            }
            else
            {
                selectIcon[pS.playerNumber - 1].SetActive(false);
                
            }

            if(pS.pPrefab == chara)
            {
                selectIcon[pS.playerNumber - 1].GetComponent<Animator>().SetBool("Selected", true);
            }
            else
            {
                selectIcon[pS.playerNumber - 1].GetComponent<Animator>().SetBool("Selected", false);
            }
        }
    }
}
