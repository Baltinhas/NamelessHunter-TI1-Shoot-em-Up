using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMov1 : MonoBehaviour
{
    public float speed;
    public float amplitude;
    public float frequency;
    public GameObject explosion;
    Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void FixedUpdate()
    {
        Vector3 pos = transform.position;
        pos += Vector3.back * speed * Time.fixedDeltaTime;
        pos.x = startPos.x + Mathf.Sin(pos.z * 0.5f * frequency) * amplitude;
        transform.position = pos;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("BulletPlayer"))
        {
            Destroy(other.gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
            GameController.instance.AddScore(5); // Passa o valor dos pontos aqui
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("BulletEnemy"))
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Destroy"))
        {
            Destroy(gameObject);
        }
    }
}
