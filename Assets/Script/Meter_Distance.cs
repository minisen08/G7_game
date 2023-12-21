using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meter_Distance : MonoBehaviour
{
    private Slider slider = null;
    public Image Background;
    private float enemyDistance;

    private float playerSpead;
    private float enemySpead;

    void ColorChange()
    {
        float persent = slider.value / slider.maxValue;

        if (persent * 100 <= slider.maxValue / 2)
        {
            Background.color = new Color(persent * 2f, 1f, 0f, 255);
        }
        else if (persent * 100 > slider.maxValue / 2)
        {
            Background.color = new Color(1f, 1f - (persent - slider.maxValue / 200 ) * 2 , 0f, 255);
        }
    }

    void Start()
    {
        if (GameObject.Find("Distancemeter"))
        {
            slider = (Slider)FindObjectOfType(typeof(Slider));
        }
    }

    // Update is called once per frame
    void Update()
    {
        playerSpead = Random.Range(55f, 100f);
        enemySpead = Random.Range(0f, 50f);
        enemyDistance = playerSpead - enemySpead;

        slider.value = slider.maxValue - enemyDistance;
        ColorChange();
    }
}
