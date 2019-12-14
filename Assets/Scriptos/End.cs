using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*nombre: end
autor: Juan Carlos ValdÉs Aguilar
 */
public class End : MonoBehaviour
{
    //definimos un collider que al detectar el tag player cargue la escena determinada , en este caso regrese al menú
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            Destroy(gameObject);
            Debug.Log("FIN");
            SceneManager.LoadScene(0);
        }



    }
}
