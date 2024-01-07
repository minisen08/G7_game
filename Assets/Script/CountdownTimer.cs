using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro; //TextMeshProÇégÇ§èÍçáÇÕì«Ç›çûÇ›Ç™ïKóv
using Unity.VisualScripting;

public class CountdownTimer : MonoBehaviour
{
	public TextMeshProUGUI CountText;
	public float countdown = 4f;
	private static int count = 4;
	public static bool gameStart = false;

    public AudioClip[] sound;
    AudioSource audioSource;

    void Start()
	{
		gameStart = false;
        audioSource = GetComponent<AudioSource>();
    }

	void Update()
	{
        if (count >= 0)
        {
            countdown -= Time.deltaTime;
            if(count != (int)countdown)
            {
                count = (int)countdown;
                if (count > 0)
                {
                    CountText.text = count.ToString();
                    audioSource.PlayOneShot(sound[0]);
                } else if(count == 0)
                {
                    CountText.text = "START";
                    gameStart = true;
                    audioSource.PlayOneShot(sound[1]);
                }
                else
                {
                    CountText.text = "";
                }
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