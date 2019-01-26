using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerStats : MonoBehaviour
{
    public int playerNumber;
    public GameObject pPrefab;
    public Color pColor;
    public int pIndex;
   

    public void Update()
    {
        if (Input.GetButtonDown("TriggerRight" + playerNumber))
        {
            
        }
    }
}
