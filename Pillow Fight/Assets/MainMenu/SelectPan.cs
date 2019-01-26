using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectPan : MonoBehaviour
{
    public int index;
    public GameObject chara;
    public Image img;

    void Start()
    {
        img = GetComponent<Image>();
    }

    public void UpdateThis()
    {
        img.sprite = chara.GetComponent<Character>().icon;
    }
}
