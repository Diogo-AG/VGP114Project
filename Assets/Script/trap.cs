using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class trap : MonoBehaviour
{
    public int damge;

    void Start()
    {
        // 获取所有带有 "Player" 标签的游戏对象
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

        foreach (GameObject player in players)
        {
            // 获取每个玩家对象的 Playerhealth 组件
            Playerhealth playerHealth = player.GetComponent<Playerhealth>();

            if (playerHealth != null)
            {
                // 在这里可以使用 playerHealth 进行操作
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Playerhealth playerHealth = other.GetComponent<Playerhealth>();

            if (playerHealth != null)
            {
                // 对碰到的玩家应用伤害
                playerHealth.DamegePlayer(damge);
            }
        }
    }
}
