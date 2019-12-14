using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*nombre: Enemyhealth
autor: Juan Carlos ValdÉs Aguilar
 */
public class EnemyHealth : MonoBehaviour
{
    //aqui definimos los valores que tendrán nuestras variables

    [SerializeField]
    private string newlevel;

    [SerializeField]
    private int startingHealth = 5;

    private int currentHealth;

    // en este void enable indicamos iniciar la vida inicial y checar que score esté en 0
    private void OnEnable()
    {
        FindObjectOfType<Score>();
        currentHealth = startingHealth;
    }

    // aquí definimos la instancia takedamage para definir que la vida llega a 0 y se ejecute el void die
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
