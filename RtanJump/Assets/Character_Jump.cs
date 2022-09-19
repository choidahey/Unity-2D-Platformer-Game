using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character_Jump : MonoBehaviour
{
    public Rigidbody2D rigid;
    public float jumpHeight;
    int jumpCount = 0;
    int limitJumpCount = 2;
    public AudioSource audioSource;
    public AudioClip audioClip;

    void Update()
    { 
        //키보드 입력
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (jumpCount < limitJumpCount)
            {
                jumpCount = jumpCount + 1;
                rigid.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
            }
            Debug.Log(jumpCount.ToString());
        }

        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            jumpCount = 0;
        }
        if (collision.gameObject.tag == "wall")
        {
            jumpCount = 0;
        }
        else if (collision.gameObject.tag == "enemy")
        {
            jumpCount = 0;
            EnemySaurus enemy = collision.gameObject.GetComponent<EnemySaurus>();
            enemy.OnDamage();
            rigid.AddForce(Vector2.up * 15, ForceMode2D.Impulse);
            audioSource.volume = SoundManager.I.Volume;
            audioSource.clip = audioClip;
            audioSource.Play();
        }

    }
}
