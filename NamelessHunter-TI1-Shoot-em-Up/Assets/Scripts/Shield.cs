using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public GameObject shieldObject;
    public float activationDuration = 5f;

    private bool isActivated = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!isActivated && other.CompareTag("Player"))
        {
            shieldObject.SetActive(true);
            GameController.instance.CollectItem();
            Destroy(gameObject);

            isActivated = true;
            Invoke("DeactivateShield", activationDuration);
        }
    }

    private void DeactivateShield()
    {
        shieldObject.SetActive(false);
        isActivated = false;
    }
}
