using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 获取键盘输入
        float x = 0.0f;
        float y = 0.0f;
        float z = 0.0f;

        if (Input.GetKey(KeyCode.W))
        {
            y = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            y = -1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            x = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            x = 1;
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            z = -1;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            z = 1;
        }

        // 计算移动方向
        Vector3 moveDirection = new Vector3(x, y, z).normalized;

        // 移动相机
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
