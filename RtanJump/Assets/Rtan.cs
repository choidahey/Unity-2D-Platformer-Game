using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rtan : MonoBehaviour //���� ������ �� �ְ� ����� ����Ƽ ���� Ŭ����
{
    public SpriteRenderer spriteRenderer;
    public Rigidbody2D rigid;
    public Transform trans;
    public float moveSpeed;

    public void Update()
    {
        // �⺻ ������ 0 �Դϴ�.
        // Vector2.zero �� Vector2(0f, 0f) �� �����ϴ�
        Vector2 direction = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // ���� Ű�� ���� ��쿣 ���� �� Vector2.left �� �̵��մϴ�
            // Vector2.left �� Vector2(-1f, 0f) �� �����ϴ�
            direction = Vector2.left * moveSpeed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = Vector2.right * moveSpeed;
        }
    }
}
