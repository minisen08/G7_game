using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meter_Distance : MonoBehaviour
{
    private Slider slider = null;
    public Image Background;
    private float EnemyDistance;

    //�ʂ̃X�N���v�g����ϐ����󂯎���ĕύX
    //private float playerSpead;  
    //private float enemySpead;
    private Player_Move Player_Move;

    //�����ɂ���ă��[�^�̐F���ς��ϐ�
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
        //���u���@�ύX����
       // playerSpead = Random.Range(55f, 100f);
       // enemySpead = Random.Range(0f, 50f);

        //EnemyDistance += playerSpead - enemySpead;
        EnemyDistance = Player_Move.EnemyDistance/50;

        slider.value = slider.maxValue - EnemyDistance;
        ColorChange();
    }
}
