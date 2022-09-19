using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Move : MonoBehaviour
{
    public Transform trans;
    public Rigidbody2D rigid;
    public SpriteRenderer render;
    public float moveSpeed;
    

    void Update()
    {    
        Vector2 direction = Vector2.zero; //키보드 입력할 때

        //키보드 입력 함수
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = Vector2.left * moveSpeed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = Vector2.right * moveSpeed;
        }
        direction.y = rigid.velocity.y;
        rigid.velocity = direction;

    }
}
