using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    public GameObject Player;
    private Player_Move Player_Move;

    private Vector3 enemyPos;

    // Start is called before the first frame update
    void Start()
    {
        enemyPos = new Vector3(this.transform.position.x, this.transform.position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        enemyPos.x = (Player.transform.position.x - 5f)-Player_Move.EnemyDistance / 30;
        transform.position = new Vector3(enemyPos.x,enemyPos.y , 0);

    }
}
