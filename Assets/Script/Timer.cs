using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; //TextMeshProを使う場合は読み込みが必要
using UnityEngine.SceneManagement; //シーン移動を行う場合は読み込みが必要

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;//時間表示用テキスト
    public static float time;  //経過時間
    public static bool timerStop = false; //外からTimer.timerStop=true;とするとタイマーストップ
    public int limit = 10; //制限時間の初期値

    public static int score;
    
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {

        score = Random.Range(1, 100000);

        if (!timerStop)//timerStopがtrueでなかったら実行
        {
            time += Time.deltaTime;
            int t = Mathf.FloorToInt(time);
            if ((limit - t) != 0)
            timerText.text = "Time:" + (limit - t);
            //timerText.text = "Time:" + t; //時間をカウントアップしたい場合はこちらを使用

            if ( (limit - t) == 0) //残り時間が0だったら
            {
                // timerStop = true; //タイマーを停止状態にする
                timerText.text = "Finish";
                time = 0;
                SceneManager.LoadScene("Result");//タイトル画面へ移動
            }
        }
    }
}


