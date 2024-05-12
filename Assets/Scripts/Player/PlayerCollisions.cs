using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    private float health;
    private float cooldown = 0.2f;
    private float cooldownTimer;
    void Start()
    {
        health = gameObject.GetComponent<Player>().health;
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Enemy") { return; }
        if (Time.time > cooldownTimer)
        {
            health -= 1;
            Debug.Log(health);
            if (health <= 0)
            {
                gameObject.GetComponent<Renderer>().material.color = new Color(150, 0, 0);
                Destroy(gameObject, 0.3f);
            }
            cooldownTimer = Time.time + cooldown;
        }
    }
}
