using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class Speedmater : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timeText;
    private Player_Move Player_Move;
    public static Speedmater instance;

    private float time;

    // Start is called before the first frame update

    public void Awake()
    {
        if (instance == null)
            instance = this;
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float speedOrigin = Player_Move.PlayerSpead;
        int speedX10 = (int)(speedOrigin * 10);
        int speedD = speedX10 / 10;
        int speedF = speedX10 % 10;
        timeText.text = "Time: " + speedD.ToString("D3") + "." + speedF.ToString("D1");

    }
}
