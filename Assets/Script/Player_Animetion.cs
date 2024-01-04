using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Animetion : MonoBehaviour
{
    Player_Move Player_Move;
    private float run = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Player_Move.finish.Equals("gameOver"))
        {
            run += Player_Move.PlayerSpead / 1000f;
            if (run >= (Mathf.PI * 2))
            {
                run = run % (Mathf.PI * 2);
            }
            float y = Mathf.Cos(run) / 2;
            float x = this.transform.position.x;
            if (Player_Move.finish.Equals("clear"))
            {
                x += Player_Move.PlayerSpead/1000;
            }
            this.transform.position = new Vector3(x, -1.5f - y, 0);
        }
        else
        {
            this.transform.position = new Vector3(this.transform.position.x+0.05f, this.transform.position.y + 0.05f, 0);
            this.transform.rotation *= Quaternion.Euler(0f,0f,20f);
        }
    }
}
