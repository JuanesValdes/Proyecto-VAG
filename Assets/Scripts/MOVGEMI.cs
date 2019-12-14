using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVGEMI : MonoBehaviour
{
    // EL controlador del player, que nos servirá para delimitar los movimientos que hará cada que presionemos x tecla

    // Start is called before the first frame update
    public float velocidad=5;
    public float salto = 3;
    public float rotar = 50;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * salto * Time.deltaTime);
        }
        // AQUI entran 2 teclas clave para el gameplay, ya que con ellas rotaremos al player para ajustarnos al nivel y avanzar de mejor forma

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.down * rotar * Time.deltaTime);
            //transform.localEulerAngles = new Vector3(0, -rotar, 0);
        }

       if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up * rotar * Time.deltaTime);
            //transform.localEulerAngles = new Vector3(0, rotar, 0);
          
        }
    }
}
