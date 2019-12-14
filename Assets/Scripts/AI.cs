using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public Transform _destino;
    NavMeshAgent _Agente;
    float speedAgent;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        _Agente = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        speedAgent = _Agente.speed;

        if (_Agente !=null)
        {
            _Agente.SetDestination(_destino.position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("speed", speedAgent);
    }
}
