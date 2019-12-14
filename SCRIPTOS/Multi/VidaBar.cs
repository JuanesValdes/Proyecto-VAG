using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaBar : MonoBehaviour
{
    public Slider[] barras;
    public int life;
    Enemigo vida;

    // Start is called before the first frame update
    void Start()
    {
        vida = GetComponentInParent<Enemigo>();


        StartCoroutine("asignarBarra");

    }

    // Update is called once per frame
    void Update()
    {
        barras[0].value = vida.vida;
        if (vida.vida == 0)
        {
            transform.parent.gameObject.SetActive(false);
        }
    }

    IEnumerator asignarvida()
    {
        yield return new WaitForSeconds(1);
        if (vida != null)
        {
            //vida = vida.life;
            barras[0].maxValue = life;
            barras[0].value = barras[0].maxValue;
        }
    }

    //IEnumerator asignarBarra()
    //{
    //    yield return new WaitForSeconds(1);
    //    barras = new Slider[2];
    //    barras = GetComponentsInChildren<Slider>();
    //    vida = vida.life;
    //    for (int i = 0; i < barras.Length; i++)
    //    {
    //        barras[i] = barras[i];
    //        if (i == 0)
    //        {
    //            barras[i].maxValue = life;
    //            barras[i].value = barras[i].maxValue;
    //        }
    //    }
    //}
}
