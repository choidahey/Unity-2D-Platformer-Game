using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDamage : MonoBehaviour
{
    public BoxCollider2D col1;
    public BoxCollider2D col2;
    public SpriteRenderer render;  //몸 투명하게 만들기

    void OnDamage()
    {
        col1.enabled = false;
        col2.enabled = false;
        render.color = new Color(1, 1, 1, 0.5f);   //색 투명화
        GameManager.I.GameOver();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            OnDamage();
        }
    }

}
