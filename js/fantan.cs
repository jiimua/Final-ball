using UnityEngine;

public class fantan : MonoBehaviour
{
    public float additionalBounceForce = 5f; // 额外弹跳力的大小
    public float forceDamping = 0.1f; // 每秒减少的速度百分比

    private Rigidbody2D rb2D;

    void Start()
    {
        // 获取小球的 Rigidbody2D 组件
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 每帧减少一部分垂直速度
        rb2D.velocity = new Vector2(rb2D.velocity.x, rb2D.velocity.y * (1 - forceDamping * Time.deltaTime));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 确认 Rigidbody2D 组件存在
        if (rb2D != null)
        {
            // 计算反弹力的方向和大小
            Vector2 bounceForce = Vector2.up * additionalBounceForce;

            // 在小球的当前速度基础上增加额外的反弹力
            rb2D.AddForce(bounceForce, ForceMode2D.Impulse);
        }
    }
}