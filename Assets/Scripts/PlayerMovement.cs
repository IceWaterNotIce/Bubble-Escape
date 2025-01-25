using UnityEngine;
using UnityEngine.InputSystem;

/**
 * 玩家移動腳本
 */
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 2f; // 移動速度
    public float pushForce = 5f; // 推進力
    private Vector2 moveInput; // 儲存移動輸入
    private InputSystem_Actions playerInputActions; // 輸入動作類

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 初始化輸入動作
        playerInputActions = new InputSystem_Actions();
        playerInputActions.Player.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        playerInputActions.Player.Move.canceled += ctx => moveInput = Vector2.zero;
        playerInputActions.Player.Jump.performed += ctx => OnJump();
        playerInputActions.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // 移動角色
        transform.Translate(moveInput.x * moveSpeed * Time.deltaTime, 0, 0);
    }

    // 處理空格鍵按下事件
    private void OnJump()
    {
        // 如果沒有按下 WASD，則默認為按下 W
        if (moveInput == Vector2.zero)
        {
            moveInput = new Vector2(0, 1); // 默認向上推進
        }

        // 根據當前的移動輸入推進角色
        transform.Translate(moveInput.x * pushForce * Time.deltaTime, moveInput.y * pushForce * Time.deltaTime, 0);
    }
}
