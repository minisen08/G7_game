using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{

    public TextMeshProUGUI rank1;
    public TextMeshProUGUI rank2;
    public TextMeshProUGUI rank3;
    public TextMeshProUGUI rank4;
    public TextMeshProUGUI rank5;
    public TextMeshProUGUI newscore;

    private const int RANK = 5;    //ランキングに表示する数
    private static int scorevalue; //ゲームスコアを受け取る変数
    private static bool isActive = true;
    public static bool isScore = true;
    private string beforeScene;

    private int i;

    private struct RANKING
    {
        public int rank;
        public int score; 
    }

    private static RANKING[] ranking = new RANKING[RANK];

    void Initialization()
    {
        for (int i = 0; i < RANK; i++)
        {
            ranking[i] = new RANKING() { rank = i + 1, score = 0};
        }
    }

    //スコアを格納する関数
    void SetScore()
    {
        for (i = 0; i < RANK; i++)
        {
            if (ranking[i].score < Timer.score)
            {
                for (int j = RANK-1; j > i; j--)
                {
                    ranking[j].score = ranking[j - 1].score;
                }

                ranking[i].score = scorevalue;
                break;
            }
        }

    }

    void ActiveScore()
    {
        rank1.text = ranking[0].rank + ":" + ranking[0].score;
        rank2.text = ranking[1].rank + ":" + ranking[1].score;
        rank3.text = ranking[2].rank + ":" + ranking[2].score;
        rank4.text = ranking[3].rank + ":" + ranking[3].score;
        rank5.text = ranking[4].rank + ":" + ranking[4].score;
        newscore.text = "New:" + scorevalue;
    }

    void Awake()
    {
        if (isActive)
        {
            Initialization();
            isActive = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if (isScore)
        {
            scorevalue = Timer.score;       //ちゃんとしたスコアに書き換える
            SetScore();
            isScore = false;
        }

        ActiveScore();
    }

    // Update is called once per frame
    void Update()
    {        
        
    }
}
