using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meter_Distance : MonoBehaviour
{
    private Slider slider = null;
    public Image Background;
    private float EnemyDistance;

    //別のスクリプトから変数を受け取って変更
    //private float playerSpead;  
    //private float enemySpead;
    private Player_Move Player_Move;

    //距離によってメータの色が変わる変数
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
        //仮置き　変更部分
       // playerSpead = Random.Range(55f, 100f);
       // enemySpead = Random.Range(0f, 50f);

        //EnemyDistance += playerSpead - enemySpead;
        EnemyDistance = Player_Move.EnemyDistance/50;

        slider.value = slider.maxValue - EnemyDistance;
        ColorChange();
    }
}
