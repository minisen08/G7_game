using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
	public Text timeTexts;
	public Text CountText;
	float totalTime = 10;
	int retime;
	float countdown = 3f;
	int count;

	void Start()
	{

	}

	void Update()
	{
		if(countdown >= 0)
		{
			countdown -= Time.deltaTime;
			count = (int)countdown;
			CountText.text = count.ToString();
		}
		
		if(countdown <= 0)
		{
			CountText.text = "";
			totalTime -= Time.deltaTime;
			retime = (int)totalTime;
			timeTexts.text = retime.ToString();
		}
	}
}