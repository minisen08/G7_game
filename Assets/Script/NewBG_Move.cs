using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBG_Move : MonoBehaviour
{

    private float length;
    private float dist = 0f;
    public float spead;

    // Start is called before the first frame update
    void Start()
    {
        // ”wŒi‰æ‘œ‚Ìx²•ûŒü‚Ì•
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {

        //dist -= allMove.PlayerSpead/2000;
        dist = (Player_Move.PlayerPos / -15) * spead;
        float a = dist % length + length / 2;
        transform.position = new Vector3(a, transform.position.y, transform.position.z);
    }
}
