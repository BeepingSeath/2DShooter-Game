using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField]private GameObject bulletPrefab;
    [SerializeField]private GameObject player;
    private Transform gun;

    void Start(){
        gun = player.transform.Find("Gun");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
        Instantiate(bulletPrefab, gun.transform.position, gun.transform.rotation);
        }
    }
}
