using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Player player;
    public Slider slide;

    public void Start()
    {
        slide = GetComponent<Slider>();
    }

    void Update()
    {
        slide.value = player.health;
    }
}
