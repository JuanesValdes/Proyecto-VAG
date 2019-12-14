using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*nombre: cambioesc
autor: Juan Carlos ValdÉs Aguilar
 */
public class CambioEsc : MonoBehaviour
{
    // definimos en estos fields cuales serán las escenas a cargar dentro de unity

    [SerializeField]
    private string newlevel;

    [SerializeField]
    private string newlevel2;

    // Update para verificar que al presionar la tecla definida,cambie a la escena indicada anteriormente
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(newlevel);

        }

        if (Input.GetKey(KeyCode.M))
        {
            SceneManager.LoadScene(newlevel2);

        }
    }
}
