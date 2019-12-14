using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*nombre: EPlayerHealth
autor: Juan Carlos ValdÉs Aguilar
 */

    //definimos los valores de la vida
public class PlayerHealth : MonoBehaviour
{

    [SerializeField]
    private int startingHealth = 5;

    private int currentHealth;

   [SerializeField]
    private string newlevel;

    void start()
    {
        FindObjectOfType<Score>();
    }

    private void OnEnable()
    {
        currentHealth = startingHealth;
    }
    //indicamos que cuando el contador de vida llegue a 0 , sume 10 puntos al score y se ejecute después el void die que desactiva al object
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <= 0)

        {
            Score.score += 10;

            Die();
        }
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
}
