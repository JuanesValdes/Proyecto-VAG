using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemigo2 : MonoBehaviour
{
    [SerializeField]
    private string end;

    public GameObject playeresp;
    private Respawn Rp;

    public float vida = 50f;

    public SkinnedMeshRenderer render;
    public Transform respawnPoint;

    public void Update()
    {
        if (Score2.score2 == 50)
        {
            StartCoroutine(End());
           
        }
    }
    public void TakeDamage (float amount)
    {
        vida -= amount;
        if (vida <= 0f)
        {
            vida = 0;
            Score.score += 10;
            Muere();
        }

    }

    private void Muere()
    {
        render.enabled = false;
        transform.position = respawnPoint.position;

        StartCoroutine(Respawner());

        //Destroy(gameObject);
        //Respawn();




    }

    IEnumerator Respawner()
    {
        yield return new WaitForSeconds(3);
        render.enabled = true;
        vida = 50;
        
        
            
    }

    IEnumerator End()
    {
        
            yield return new WaitForSeconds(2);
            Destroy(gameObject);
            SceneManager.LoadScene(end);
        
    }

    //void Respawn()
    // {
    //     GameObject objPosd = Instantiate(playeresp) as GameObject;
    //     objPosd.transform.position = Rp.respawn.position;
    // }


}
