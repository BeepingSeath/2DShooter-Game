using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed;
    void Start()
    {
        speed = gameObject.GetComponent<Player>().speed;
    }

    // Update is called once per frame
    void Update()
    {
            float HorizontalMovement = Input.GetAxis("Horizontal") * speed;
            float VerticalMovement = Input.GetAxis("Vertical") * speed;

            HorizontalMovement *= Time.deltaTime;
            VerticalMovement *= Time.deltaTime;

            transform.Translate(HorizontalMovement,VerticalMovement,0,Space.World);
    }
}
