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
        run += Player_Move.PlayerSpead/1000f;
        if (run >= (Mathf.PI * 2))
        {
            run = run % (Mathf.PI*2);
        }
        float y = Mathf.Cos(run)/2;
        this.transform.position = new Vector3(this.transform.position.x,-1.5f-y,0);
    }
}
