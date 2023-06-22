using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2.0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("Limit"))
        {
            Destroy(gameObject);
        }
       
    }
}
