using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Player player;

    private void Start()
    {
        player = GetComponent<Player>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Hit");
            player.playerHealth = 0;
            player.Die();
        }
    }
}
