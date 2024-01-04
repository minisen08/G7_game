using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro; //TextMeshPro‚ðŽg‚¤ê‡‚Í“Ç‚Ýž‚Ý‚ª•K—v

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
		if(countdown > 1)
		{
			countdown -= Time.deltaTime;
			count = (int)countdown;
			CountText.text = count.ToString();
		}

        if (countdown <= 1 && countdown > 0)
        {
			CountText.text = "START";
			countdown -= Time.deltaTime;
		}
		
		if(countdown <=0)
		{
			CountText.text = "";
		}
	}
}