using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_ : MonoBehaviour
{
    public float moveSpeed = 5f; // �ƶ��ٶ�

    // ��ÿһ֡����
    void Update()
    {
        // ��ȡˮƽ�ʹ�ֱ����
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // �����ƶ�����
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // �ƶ�����
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
