using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    private BossController bossController;

    private void Start()
    {
        // Encontrar a referência para o componente BossController
        bossController = FindObjectOfType<BossController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BulletPlayer"))
        {
            // Verificar se o objeto atingido tem a tag "Alvo"
            if (gameObject.CompareTag("Alvo"))
            {
                // Destruir o objeto atingido
                Destroy(gameObject);

                // Informar ao BossController que um objeto alvo foi destruído
                bossController.TargetDestroyed();
            }
        }
    }
}