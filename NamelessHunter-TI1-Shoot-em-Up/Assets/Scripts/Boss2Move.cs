using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2Move : MonoBehaviour
{
    public Transform[] movePoints; // Pontos de movimento pré-determinados
    public float initialMoveSpeed = 5f; // Velocidade inicial de movimento do objeto
    public float speedIncreaseAmount = 1f; // Quantidade de aumento de velocidade a cada 5 segundos
    private float currentMoveSpeed; // Velocidade de movimento atual do objeto
    private int currentPointIndex = 0; // Índice do ponto atual
    private float timer = 0f; // Temporizador para aumentar a velocidade

    void Start()
    {
        // Verifica se há pontos de movimento atribuídos ao objeto
        if (movePoints.Length == 0)
        {
            Debug.LogError("Não foram atribuídos pontos de movimento ao objeto!");
            return;
        }

        // Define a posição inicial do objeto como o primeiro ponto de movimento
        transform.position = movePoints[currentPointIndex].position;

        // Define a velocidade inicial do objeto
        currentMoveSpeed = initialMoveSpeed;
    }

    void Update()
    {
        // Verifica se o objeto chegou ao ponto de movimento atual
        if (transform.position == movePoints[currentPointIndex].position)
        {
            // Seleciona um próximo ponto de movimento aleatoriamente
            int randomIndex = Random.Range(0, movePoints.Length);
            currentPointIndex = randomIndex;
        }

        // Move o objeto em direção ao ponto de movimento atual com a velocidade atual
        transform.position = Vector3.MoveTowards(transform.position, movePoints[currentPointIndex].position, currentMoveSpeed * Time.deltaTime);

        // Atualiza o temporizador
        timer += Time.deltaTime;

        // Verifica se o temporizador atingiu 8 segundos
        if (timer >= 8f)
        {
            // Aumenta a velocidade atual do objeto
            currentMoveSpeed += speedIncreaseAmount;

            // Reinicia o temporizador
            timer = 0f;
        }
    }
}