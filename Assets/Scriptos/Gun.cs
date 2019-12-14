using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*nombre: Gun
autor: Juan Carlos ValdÉs Aguilar
 */
public class Gun : MonoBehaviour
{
    //public int ammo;

    [SerializeField]
    [Range(0.5f, 1.5f)]
    private float fireRate = 1;


    [SerializeField]
    [Range(1, 10)]
    private int damage = 1;

    [SerializeField]
    private ParticleSystem muzzleParticle;

    [SerializeField]
    private AudioSource gunFireSource;

    private float timer;

    public GameObject impactEffect;

    // checamos la vida del enemy, ponemos un timer para el firerate y mandamos a llamar el input fire 1 para ejecutar el void FireGun
    void Update()
    {
        FindObjectOfType<EnemyHealth>();

        timer += Time.deltaTime;
        if (timer >= fireRate)
        {
            if (Input.GetButton("Fire1"))
            {
                timer = 0f;
                FireGun();
            }
        }
    }

    // indicamos que se ejecuten las particulas y sonidos definidos en unity, mandamos a generar un raay que determinará la dirección del disparo y definimos que al hacer contacto se ejecute el comando takedamage
    private void FireGun()
    {

        muzzleParticle.Play();
        gunFireSource.Play();

        Ray ray = Camera.main.ViewportPointToRay(Vector3.one * 0.5f);

        Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow, 2f);

        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo,100))
        {
           var health = hitInfo.collider.GetComponent<EnemyHealth>();

            if (health != null)
            {
                health.TakeDamage(damage);
            }

            GameObject impactGO = Instantiate(impactEffect, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
            Destroy(impactGO, 2f);
        }

    }
}
