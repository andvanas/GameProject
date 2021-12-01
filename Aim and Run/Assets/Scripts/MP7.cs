using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MP7 : MonoBehaviour
{
    public float damage = 50f;
    public float range = 100f;
    public float impactForce = 30f;
    public float fireRate = 9f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public AudioSource gunShot;

    private float nextShot = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1") && Time.time >= nextShot)
        {
            nextShot = Time.time + 1f / fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        muzzleFlash.Play();
        gunShot.Play();
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Target shotTarget = hit.transform.GetComponent<Target>();

            if (shotTarget != null)
            {
                shotTarget.TakeDamage(damage);
            }

            if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
        }
    }
        
}
