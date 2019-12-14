using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*nombre: Enemy
autor: Juan Carlos ValdÉs Aguilar
 */
public class Enemy : MonoBehaviour
{
 
    [SerializeField]
    private float attackRefreshRate = 1.5f;

    private Detector detector;
    private EnemyHealth healthTarget;
    
    private float attackTimer;

    private void Awake()
    {
     
        detector = GetComponent<Detector>();
        detector.OnDetect += Detector_OnDetect;
        
    }

    // mandamos llamar el detect de la vida 
    private void Detector_OnDetect(Transform target)
    {
        EnemyHealth health = target.GetComponent<EnemyHealth>();
        if ( health != null)
        {
            healthTarget = health;
        }
    }
    // estamos revisando constantemente el status de su vida
    private void Update()
    {
        if (healthTarget != null)
        {
            attackTimer += Time.deltaTime;
            if (CanAttack())
            {
                Attack();
            }
               
        }

    }

    private bool CanAttack()
    {
        return attackTimer >= attackRefreshRate;
    }

    private void Attack()
    {
        attackTimer = 0;
        healthTarget.TakeDamage(1);
    }
}
