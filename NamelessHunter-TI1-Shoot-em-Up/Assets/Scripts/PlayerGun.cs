 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    public KeyCode key;
    public GameObject Bullet;

    void Update()
    {
        if(Input.GetKeyDown(key)) 
        {
            Fire();      
        }
    }

    void Fire()
    {
        Instantiate(Bullet, transform.position, transform.rotation);
    }
}
