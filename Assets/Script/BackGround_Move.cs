using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround_Move : MonoBehaviour
{
    private float speed;
    public float velocity = 0f;
    private Player_Move Player_Move;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        speed = Player_Move.PlayerSpead;

        transform.position = new Vector3(transform.position.x - (velocity + speed / 2) * Time.deltaTime, transform.position.y, 0);

        if (this.transform.position.x <= -52)
        {
            transform.position = new Vector3(118, 0.4f, 0);
        }

    }
}
