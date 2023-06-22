 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    public float time;
    public GameObject Bullet;
    void Start()
    {
        InvokeRepeating("Fire", 0 , time);
    }

    void Fire()
    {
        Instantiate(Bullet, transform.position, transform.rotation);
    }
   
}
