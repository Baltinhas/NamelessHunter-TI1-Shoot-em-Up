using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public float speedX, speedY;
    Rigidbody rb;
    public Blinking blinking;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 vel = rb.velocity;
        vel.x = h * speedX;
        vel.z = 2.0f + speedY * v;
        rb.velocity = vel;
        transform.rotation = Quaternion.Euler(0, 0, -30 * h);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("BulletEnemy") || other.gameObject.CompareTag("Enemy"))
        {
            GameController.instance.PlayerHit();
            blinking.PlayBlink();
            Destroy(other.gameObject);

        }

    }

}