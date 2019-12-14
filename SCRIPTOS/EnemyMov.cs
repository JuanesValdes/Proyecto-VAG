using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/*nombre: Enemymov
autor: Juan Carlos ValdÉs Aguilar
 */

public class EnemyMov : MonoBehaviour
{
    // haciendo uso del navmesh haremos que el enemigo se desplace por el entorno

    private NavMeshAgent navMeshAgent;
    private Animator animator;
    private Detector detector;
    private Transform target;

    // en void awake lo iniciamos manando llamar al componente navmesh, , el detector y sus animaciones establecidas en unity
    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
        detector = GetComponent<Detector>();
        detector.OnDetect += Detector_OnDetect;
    }

    private void Detector_OnDetect(Transform target)
    {
        this.target = target;
    }
    private void Update()
    {
        if(target != null)
        {
            navMeshAgent.SetDestination(target.position);

            float currentSpeed = navMeshAgent.velocity.magnitude;
            animator.SetFloat("Speed", currentSpeed);
        }
      
    }

}
