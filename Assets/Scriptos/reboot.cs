using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*nombre: Reboot
autor: Juan Carlos ValdÉs Aguilar
 */
public class reboot : MonoBehaviour
{
    [SerializeField]
    private string newlevel;

    // simplemente indicamos a base de un if que cada que la tecla P sea pulsada cargue la escena indicada
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            SceneManager.LoadScene(newlevel);

        }
    }
}
