using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombi : MonoBehaviour
{
    public Rigidbody2D rigid;
    public SpriteRenderer render;
    public float moveSpeed;
    bool isLeft = true;
    bool isDead = false;

    void Update()
    {
        if (isDead)
        {
            return;
        }

        if (isLeft)
        {
            rigid.velocity = Vector2.left * moveSpeed;
            render.flipX = false;
        }
        else
        {
            rigid.velocity = Vector2.right * moveSpeed;
            render.flipX = true;
        }
    }

    public void OnDamage()
    {
        BoxCollider2D col = gameObject.GetComponent<BoxCollider2D>();  //자신한테서 가져옴
        col.enabled = false;
        render.color = new Color(1, 1, 1, 0.5f);
        rigid.AddForce(Vector2.up * 6, ForceMode2D.Impulse);
        isDead = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            isLeft = !isLeft;
        }
    }
}
