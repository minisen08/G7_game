using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Move : MonoBehaviour
{
    /*=====================================
     変数を使う際は、変数の一文字目を大文字にしてください
     ======================================*/


    //各種変数
    private static float playerSpead = 0;
    private static float enemySpead = 0;
    private static float enemyDistance = 300;
    private static float playerPos = 0;

    private static float resultTime = 3f;

    //Geter
    public static float PlayerSpead
    {
        get { return playerSpead; }
    }
    public static float EnemySpead
    {
        get { return enemySpead; }
    }
    public static float EnemyDistance
    {
        get { return enemyDistance; }
    }
    public static float PlayerPos
    {
        get { return playerPos; }
    }

    //定数(バランス調整用)
    private const float ENEMY_ACCEL = 10f;
    private const float TIME_CONST = 60;
    private const float ENEMY_FIRST_DISTANCE = 1000;
    private const float PLAYER_ACCEL = 1000;
    private const float PLAYER_DECEL = 30f;
    private const float PLAYER_DECEL_ASSIST = 100;

    //プログラム実行用
    public static string lastButton = "default";
    public static string finish = "false";

    public GameObject Seed;

    public AudioClip[] sound;
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        playerSpead = 0;
        enemySpead = 0;
        enemyDistance = ENEMY_FIRST_DISTANCE;
        playerPos = 0;
        lastButton = "default";
        finish = "false";
        resultTime = 3f;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CountdownTimer.gameStart && finish.Equals("false"))  
        {

            enemySpead += ENEMY_ACCEL * Time.deltaTime;
            enemyDistance += playerSpead * Time.deltaTime - enemySpead * Time.deltaTime;
            playerPos += playerSpead / TIME_CONST;
            playerSpead -= PLAYER_DECEL * Time.deltaTime;
            if (playerSpead < 0.1)
            {
                playerSpead = 0.0f;
            }

            //走る制御(正しく入力されたらaccelをtrueにする)
            if (Input.GetKeyDown(KeyCode.LeftArrow) && !lastButton.Equals("Left"))
            {
                lastButton = "Left";
                playerSpead += (1 / (playerSpead + PLAYER_DECEL_ASSIST)) * PLAYER_ACCEL;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && !lastButton.Equals("Right"))
            {
                lastButton = "Right";
                playerSpead += (1 / (playerSpead + PLAYER_DECEL_ASSIST)) * PLAYER_ACCEL;
            }
            if (Input.GetKeyDown(KeyCode.Space)&&lastButton.Equals("default"))
            {
                audioSource.PlayOneShot(sound[0]);
                Score.score += 100;
                for(int i = 0; i < 3; i++)
                {
                    GameObject seed = Instantiate(Seed,new Vector3(2f,-1f,-1),Quaternion.identity);
                }
            }
            if (enemyDistance <= 0)
            {
                audioSource.PlayOneShot(sound[1]);
                finish = "gameOver";
                Score.score = 0;
            }
            if (playerPos > 5000)
            {
                audioSource.PlayOneShot(sound[2]);
                finish = "clear";
            }
        }
        else
        if(!finish.Equals("false"))
        {
            resultTime -= Time.deltaTime;
            if (resultTime<0)
            {
                SceneManager.LoadScene("Result");
            }
        }
    }
}
