using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


/*nombre: detector
autor: Juan Carlos ValdÉs Aguilar
 */
public class Detector : MonoBehaviour
{ 
    // definimos un detector que identificará al target cuando entre en un determinado rango para así seguirlo hasta su posición

    public event Action<Transform> OnDetect = delegate { };
    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<MovPlayer>();

        if (player != null)
        {
            OnDetect(player.transform);
            Debug.Log("detector");
        }
    }
}
