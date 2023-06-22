using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossController : MonoBehaviour
{
    public string bossName; // Nome do boss
    public Text bossNameText; // Refer�ncia para o Text do canvas
    private int targetCount; // Quantidade de objetos alvo
    private int destroyedTargetCount; // Quantidade de objetos alvo destru�dos
    private bool isDestroyed; // Flag indicando se o boss foi destru�do

    private void Start()
    {
        // Desativar o texto no in�cio
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

        // Verificar se todos os objetos alvo foram destru�dos
        if (destroyedTargetCount >= targetCount && !isDestroyed)
        {
            isDestroyed = true;

            // Implemente a l�gica para o boss ser destru�do aqui
            Debug.Log("O boss foi destru�do!");
            // Por exemplo, voc� pode desativar o boss e exibir uma mensagem de vit�ria
            gameObject.SetActive(false);
            bossNameText.gameObject.SetActive(false);
            GameController.instance.Victory();
        }
    }
}