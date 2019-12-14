using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    //public float impactForce = 30f;

    public Camera thrCam;
    public ParticleSystem muzzleFlash;
    public AudioSource gunFire;

    public GameObject impactEffect;


    // Update is called once per frame
    void Update()
    {
      if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        muzzleFlash.Play();
        gunFire.Play();

        RaycastHit hit;
        if (Physics.Raycast(thrCam.transform.position, thrCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Enemigo2 target = hit.transform.GetComponent<Enemigo2>();
            if ( target!= null)
            {
                target.TakeDamage(damage);
            }

            //if (hit.rigidbody != null)
            //{
            //    hit.rigidbody.AddForce(-hit.normal * impactForce);
            //}

            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 2f);
        }
    }
}
