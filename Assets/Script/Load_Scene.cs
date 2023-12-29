using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Scene : MonoBehaviour
{
    public void LoadingGame()
    {
        SceneManager.LoadScene("Game");
        ScoreManager.isScore = true;
    }

    public void LoadingResult()
    {
        SceneManager.LoadScene("Result");
    }

    public void LoadingTitle()
    {
        SceneManager.LoadScene("Title");
        Score.score = 0;
    }
}
