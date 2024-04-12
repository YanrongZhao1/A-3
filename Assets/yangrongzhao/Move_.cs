using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_ : MonoBehaviour
{
    public float moveSpeed = 5f; // 移动速度

    // 在每一帧更新
    void Update()
    {
        // 获取水平和垂直输入
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // 计算移动方向
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // 移动物体
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
