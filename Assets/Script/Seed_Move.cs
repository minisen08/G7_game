using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed_Move : MonoBehaviour
{

    private float spX,spY;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        spX = Random.Range(-0.08f,-0.01f);
        spY = Random.Range(0.03f, 0.06f);
        time = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        float x, y;
        x = this.transform.position.x + spX;
        spY -= 0.001f;
        if (this.transform.position.y < -3f)
        {

            spY = spY * -0.5f;
            spX = spX * 0.8f;
            y = -3f + spY;
        }
        else
        {
            y = this.transform.position.y + spY;

        }
        this.transform.position = new Vector3(x,y, this.transform.position.z);
        time -= Time.deltaTime;
        if (time<=0)
        {
            Destroy(this.gameObject);
        }
    }
}
