using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private float speed;

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = GameObject.Find("Player").transform.position;
        Vector3 direction = playerPosition - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.Translate(speed * Time.deltaTime,0,0);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") { return; }
        health -= 1;
        if (health <= 0)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(150, 0, 0);
            Destroy(gameObject, 0.3f);
        }
    }

}
