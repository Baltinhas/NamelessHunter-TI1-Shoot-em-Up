using UnityEngine;
using UnityEngine.UI;

public class Boss2Controller : MonoBehaviour
{
    public int maxHits = 10; // Número máximo de vezes que o objeto Boss2 pode ser atingido
    private int currentHits = 0; // Número atual de vezes que o objeto Boss2 foi atingido

    public Slider healthSlider; // Referência para o Slider de vida no Canvas

    private void OnCollisionEnter(Collision collision)
    {
        // Verifica se a colisão foi com um objeto com a tag "BulletPlayer"
        if (collision.gameObject.CompareTag("BulletPlayer"))
        {
            currentHits++; // Incrementa o contador de hits

            // Atualiza o valor do Slider de vida
            float healthPercentage = (float)currentHits / maxHits;
            healthSlider.value = 1f - healthPercentage;

            // Verifica se o número de hits atingiu o limite máximo
            if (currentHits >= maxHits)
            {
                Destroy(gameObject); // Destroi o objeto Boss2
            }
        }
    }
}