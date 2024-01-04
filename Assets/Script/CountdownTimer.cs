using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro; //TextMeshProを使う場合は読み込みが必要
using Unity.VisualScripting;

public class CountdownTimer : MonoBehaviour
{
	public TextMeshProUGUI CountText;
	public float countdown = 4f;
	private int count;
	public static bool gameStart = false;

	void Start()
	{
		gameStart = false;
	}

	void Update()
	{
        if (!gameStart)
        {
            if (countdown > 1)
            {
                countdown -= Time.deltaTime;
                count = (int)countdown;
                CountText.text = count.ToString();
            }
            else if (countdown > 0)
            {
                CountText.text = "START";
                countdown -= Time.deltaTime;
            }
            else
            {
                CountText.text = "";
                gameStart = true;
            }
        }
        else
        {
            if (Player_Move.finish.Equals("gameOver"))
            {
                CountText.text = "GAME OVER";
            } else if (Player_Move.finish.Equals("clear"))
            {
                CountText.text = "GOAL!!";
            }
        }
	}
}