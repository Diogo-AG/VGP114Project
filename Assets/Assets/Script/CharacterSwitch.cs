using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitch : MonoBehaviour
{
    public Transform position1;
    public Transform position2;

    private bool isAtPosition1 = true;
    private bool isSwitched = false; // 用于跟踪是否已经切换过位置

    void Update()
    {
        // 检测空格键的按下
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isSwitched)
            {
                // 如果已经切换过位置，再次按下空格键时回到位置1
                transform.position = position1.position;
                isAtPosition1 = true;
                isSwitched = false; // 重置切换状态
            }
            else
            {
                // 如果还没有切换过位置，切换到位置2
                transform.position = position2.position;
                isAtPosition1 = false;
                isSwitched = true; // 设置切换状态为已切换
            }
        }
    }
}