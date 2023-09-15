using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerateFall : MonoBehaviour
{
    public float extraFallSpeed = 2.0f; // 调整此值以控制额外的下落速度

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // 检查是否正在下降
        if (rb.velocity.y < 0)
        {
            // 应用额外的下落速度
            Vector2 extraSpeed = new Vector2(0, -extraFallSpeed * Time.deltaTime);
            rb.velocity += extraSpeed;
        }
    }
}