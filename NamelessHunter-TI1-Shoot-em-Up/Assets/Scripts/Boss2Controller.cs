using UnityEngine;
using UnityEngine.UI;

public class Boss2Controller : MonoBehaviour
{
    public int maxHits = 10; // N�mero m�ximo de vezes que o objeto Boss2 pode ser atingido
    private int currentHits = 0; // N�mero atual de vezes que o objeto Boss2 foi atingido

    public Slider healthSlider; // Refer�ncia para o Slider de vida no Canvas

    private void OnCollisionEnter(Collision collision)
    {
        // Verifica se a colis�o foi com um objeto com a tag "BulletPlayer"
        if (collision.gameObject.CompareTag("BulletPlayer"))
        {
            currentHits++; // Incrementa o contador de hits

            // Atualiza o valor do Slider de vida
            float healthPercentage = (float)currentHits / maxHits;
            healthSlider.value = 1f - healthPercentage;

            // Verifica se o n�mero de hits atingiu o limite m�ximo
            if (currentHits >= maxHits)
            {
                Destroy(gameObject); // Destroi o objeto Boss2
            }
        }
    }
}