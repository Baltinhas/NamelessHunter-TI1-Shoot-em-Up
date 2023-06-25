using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinking : MonoBehaviour
{
    public Material material;
    public bool isBlinking;
    public Color c2;
    private Color c1;
    private float t;

    void Start()
    {
        c1 = material.color;
    }

    void FixedUpdate()
    {
        if (isBlinking)
        {
            t = Mathf.PingPong(Time.time * 10.0f, 1.0f);
            material.color = Color.Lerp(c1, c2, t);
        }
    }

    public void PlayBlink()
    {
        isBlinking = true;
        Invoke("StopBlinking", 0.5f);
    }

    void StopBlinking()
    {
        isBlinking = false;
        t = 0;
        StartCoroutine(ResetMaterialColor());
    }

    IEnumerator ResetMaterialColor()
    {
        yield return new WaitForEndOfFrame();
        material.color = c1;
    }
}
