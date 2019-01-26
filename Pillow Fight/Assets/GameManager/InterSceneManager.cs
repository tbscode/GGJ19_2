using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterSceneManager : MonoBehaviour
{
    public static InterSceneManager iSM;

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
    }
}
