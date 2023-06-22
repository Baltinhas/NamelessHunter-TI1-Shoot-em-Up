using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossController : MonoBehaviour
{
    public string bossName; // Nome do boss
    public Text bossNameText; // Referência para o Text do canvas
    private int targetCount; // Quantidade de objetos alvo
    private int destroyedTargetCount; // Quantidade de objetos alvo destruídos
    private bool isDestroyed; // Flag indicando se o boss foi destruído

    private void Start()
    {
        // Desativar o texto no início
        bossNameText.gameObject.SetActive(false);

        // Contar a quantidade de objetos alvo com a tag "Alvo"
        GameObject[] targetObjects = GameObject.FindGameObjectsWithTag("Alvo");
        targetCount = targetObjects.Length;
        destroyedTargetCount = 0;
        isDestroyed = false;
    }

    public void ShowBossName()
    {
        // Ativar o texto e definir o nome do boss
        bossNameText.text = bossName;
        bossNameText.gameObject.SetActive(true);
    }

    public void HideBossName()
    {
        // Desativar o texto
        bossNameText.gameObject.SetActive(false);
    }

    public void TargetDestroyed()
    {
        destroyedTargetCount++;

        // Verificar se todos os objetos alvo foram destruídos
        if (destroyedTargetCount >= targetCount && !isDestroyed)
        {
            isDestroyed = true;

            // Implemente a lógica para o boss ser destruído aqui
            Debug.Log("O boss foi destruído!");
            // Por exemplo, você pode desativar o boss e exibir uma mensagem de vitória
            gameObject.SetActive(false);
            bossNameText.gameObject.SetActive(false);
            GameController.instance.Victory();
        }
    }
}