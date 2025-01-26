using UnityEngine;

class Bubble : MonoBehaviour
{
    private Rigidbody2D rb; // 玩家剛體
    void Start()
    {
        // 
        // 獲取 Rigidbody2D 組件
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float postitionY = transform.position.y;
        float scale = 0.4f + postitionY / 20;
        transform.localScale = new Vector3(scale, scale, 1);

        rb.linearVelocity = new Vector2(0, 1);
    }
}