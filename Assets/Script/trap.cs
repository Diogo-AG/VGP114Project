using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class trap : MonoBehaviour
{
    public int damge;

    void Start()
    {
        // ��ȡ���д��� "Player" ��ǩ����Ϸ����
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

        foreach (GameObject player in players)
        {
            // ��ȡÿ����Ҷ���� Playerhealth ���
            Playerhealth playerHealth = player.GetComponent<Playerhealth>();

            if (playerHealth != null)
            {
                // ���������ʹ�� playerHealth ���в���
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
                // �����������Ӧ���˺�
                playerHealth.DamegePlayer(damge);
            }
        }
    }
}
