using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour
{
    public float speed;
    private bool canMove = true;
    private bool hasPassedStopObject = false;

    private GameObject playerObject;
    private GameObject stopObject;

    void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
        stopObject = GameObject.FindGameObjectWithTag("Stop");
    }

    void FixedUpdate()
    {
        if (canMove)
        {
            transform.Translate(0, speed * Time.deltaTime, 0);

            if (!hasPassedStopObject && playerObject.transform.position.z > stopObject.transform.position.z)
            {
                hasPassedStopObject = true;
                StopCameraMovement();
            }
        }
    }

    private void StopCameraMovement()
    {
        canMove = false;
        // Adicione aqui qualquer l�gica adicional para parar o movimento da c�mera ap�s o objeto "Player" passar pelo objeto "Stop"
    }
}