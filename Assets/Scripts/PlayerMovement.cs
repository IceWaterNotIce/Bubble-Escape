using UnityEngine;
using UnityEngine.InputSystem;

/**
 * 玩家移動腳本
 */
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 0.001f; // 移動速度
    public float pushForce = 10f; // 推進力
    private Vector2 moveInput; // 儲存移動輸入
    private InputSystem_Actions playerInputActions; // 輸入動作類
    private Rigidbody2D rb; // 玩家剛體

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 初始化輸入動作
        playerInputActions = new InputSystem_Actions();
        playerInputActions.Player.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        playerInputActions.Player.Move.canceled += ctx => moveInput = Vector2.zero;
        playerInputActions.Player.Jump.performed += ctx => OnJump();
        playerInputActions.Enable();

        // 獲取 Rigidbody2D 組件
        rb = GetComponent<Rigidbody2D>();
    }

    // FixedUpdate is called once per physics frame
    void FixedUpdate()
    {
        // 根據輸入移動角色
        rb.linearVelocity = moveInput * moveSpeed + rb.linearVelocity;
        

    }

    // 處理空格鍵按下事件
    private void OnJump()
    {
        // 根據當前的移動輸入推進角色
        rb.AddForce(moveInput * pushForce, ForceMode2D.Impulse);
        Debug.Log("Jump");
    }
}
