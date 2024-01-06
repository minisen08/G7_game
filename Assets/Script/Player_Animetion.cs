using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Animetion : MonoBehaviour
{
    Player_Move Player_Move;
    private float run = 0f;
    public Sprite[] characterSprites; // キャラクターの異なる画像を格納するための配列
    private SpriteRenderer spriteRenderer;

    public AudioClip sound_anime;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CountdownTimer.gameStart)
        {
            if (Player_Move.lastButton.Equals("default"))
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    spriteRenderer.sprite = characterSprites[1];
                }
                else
                {
                    spriteRenderer.sprite = characterSprites[0];
                }
            }
            else
            {
                spriteRenderer.sprite = characterSprites[2];
            }
            if (!Player_Move.finish.Equals("gameOver"))
            {
                run += Player_Move.PlayerSpead / 1000f;
                if (run >= (Mathf.PI * 2))
                {
                    if (Player_Move.finish.Equals("false"))
                    {
                        audioSource.PlayOneShot(sound_anime);
                    }
                    run = run % (Mathf.PI * 2);
                }
                float y = Mathf.Cos(run) / 2;
                float x = this.transform.position.x;
                if (Player_Move.finish.Equals("clear"))
                {
                    x += Player_Move.PlayerSpead / 1000;
                }
                this.transform.position = new Vector3(x, -1.5f - y, 0);
            }
            else
            {
                this.transform.position = new Vector3(this.transform.position.x + 0.05f, this.transform.position.y + 0.05f, 0);
                this.transform.rotation *= Quaternion.Euler(0f, 0f, 20f);
            }
        }
    }
}
