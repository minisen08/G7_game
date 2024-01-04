using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro; //TextMeshProを使う場合は読み込みが必要

public class CountdownTimer : MonoBehaviour
{
	public TextMeshProUGUI CountText;
	public float countdown = 4f;
	private int count;

	void Start()
	{

	}

	void Update()
	{
		if(countdown > 0)
		{
			countdown -= Time.deltaTime;
			count = (int)countdown;
			CountText.text = count.ToString();
		}

        if (countdown <= 0 && countdown > -1)
        {
			CountText.text = "START";
			countdown -= Time.deltaTime;
		}
		
		if(countdown <=-1)
		{
			CountText.text = "";
		}
	}
}