using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class VideoClip : MonoBehaviour
{
    public TextMeshProUGUI text;

    public void Pic1()
    {
        text.text = "Hey Sister, look! It's so cold outside. What should we do?";
    }

    public void Pic2()
    {
        text.text = "Don't worry. I have an idea!";
    }

    public void Pic3()
    {
        text.text = "Let's do some property damage with these things!";
    }

    public void EndScene()
    {
        text.text = "";
        SceneManager.LoadScene("MainMenu");
    }

    public void Update()
    {
        if(Input.GetButtonDown("Submit"))
        {
            EndScene();
        }
    }

    public void ClearText()
    {
        text.text = "";
    }
}
