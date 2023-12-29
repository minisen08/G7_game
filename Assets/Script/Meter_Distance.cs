using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Meter_Distance : MonoBehaviour
{
    private Slider slider = null;
    public Image Background;
    private float EnemyDistance;

    private Player_Move Player_Move;

    //‹——£‚É‚æ‚Á‚Äƒ[ƒ^‚ÌF‚ª•Ï‚í‚é•Ï”
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

    void Update()
    {
        EnemyDistance = Player_Move.EnemyDistance/10;

        slider.value = slider.maxValue - EnemyDistance;
        ColorChange();

        if (slider.value == slider.maxValue)
        {
            SceneManager.LoadScene("Result");
        }
    }
}
