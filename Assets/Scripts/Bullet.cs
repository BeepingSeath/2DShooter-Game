using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]private GameObject explosionPrefab;
    public float speed = 10.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(1 * speed * Time.deltaTime,0,0);
        Destroy(gameObject,1);
    }

    void OnCollisionEnter2D()
    {
        Instantiate(explosionPrefab, transform.position,transform.rotation);
        Destroy(gameObject);
    }
}
