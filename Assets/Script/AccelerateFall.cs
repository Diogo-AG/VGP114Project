using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerateFall : MonoBehaviour
{
    public float extraFallSpeed = 2.0f; // ������ֵ�Կ��ƶ���������ٶ�

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // ����Ƿ������½�
        if (rb.velocity.y < 0)
        {
            // Ӧ�ö���������ٶ�
            Vector2 extraSpeed = new Vector2(0, -extraFallSpeed * Time.deltaTime);
            rb.velocity += extraSpeed;
        }
    }
}