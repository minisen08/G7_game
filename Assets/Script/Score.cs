using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; //TextMeshPro���g���ꍇ�͓ǂݍ��݂��K�v

public class Score : MonoBehaviour
{

    public TextMeshProUGUI scoreText;//���ԕ\���p�e�L�X�g
    public static float score;
    public float scorevalue = 166;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //score += scorevalue * Time.deltaTime;
        scoreText.text = "SCORE:" + (int)score;
    }
}
