using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public int score;
    public int energy = 5;
    public Text TxtScore;
    public Text TxtEnergy;
    public Text TxtTimer;
    public int healthIncrease = 5;

    public float levelDuration = 60f;
    private float timeRemaining;

    private GameObject boss; // Referência para o objeto Boss

    void Start()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);

        timeRemaining = 0f; // Começa em 00:00
        StartCoroutine(StartLevelTimer());
    }

    void FixedUpdate()
    {
        if (boss != null)
        {
            CheckVictoryCondition();
        }
    }

    IEnumerator StartLevelTimer()
    {
        yield return new WaitForSeconds(1f); // Delay inicial de 1 segundo

        while (true)
        {
            timeRemaining += 1f;
            UpdateTimerUI();
            yield return new WaitForSeconds(1f);
        }
    }

    void UpdateTimerUI()
    {
        // Verifica se o objeto TxtTimer ainda existe
        if (TxtTimer != null)
        {
            int minutes = Mathf.FloorToInt(timeRemaining / 60f);
            int seconds = Mathf.FloorToInt(timeRemaining % 60f);
            string timerText = string.Format("{0:00}:{1:00}", minutes, seconds);
            TxtTimer.text = "Time: " + timerText;
        }
    }

    private void CheckVictoryCondition()
    {
        // Verifica a condição de vitória quando o boss for destruído
        if (boss == null)
        {
            SceneManager.LoadScene("Victory");
        }
    }

    public void Fase2_Espaço()
    {
        SceneManager.LoadScene("Fase2_Espaço");
    }
    
    
    public void Victory()
    {
        SceneManager.LoadScene("Victory");
    }

    public void ActivateBoss(GameObject bossObject)
    {
        boss = bossObject;
    }

    public void AddScore(int points)
    {
        score += points;

        // Verifica se o objeto TxtScore ainda existe
        if (TxtScore != null)
        {
            TxtScore.text = "Score: " + score;
        }
    }

    public void CollectItem()
    {
        energy += healthIncrease;

        // Verifica se o objeto TxtEnergy ainda existe
        if (TxtEnergy != null)
        {
            TxtEnergy.text = "Energy: " + energy;
        }
    }

    public void PlayerHit()
    {
        energy--;

        // Verifica se o objeto TxtEnergy ainda existe
        if (TxtEnergy != null)
        {
            TxtEnergy.text = "Energy: " + energy;
        }

        if (energy <= 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}