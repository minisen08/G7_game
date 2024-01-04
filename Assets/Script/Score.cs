using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; //TextMeshProを使う場合は読み込みが必要

public class Score : MonoBehaviour
{

    public TextMeshProUGUI scoreText;//時間表示用テキスト
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
