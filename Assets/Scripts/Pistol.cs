using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Pistol : MonoBehaviour
{
    [SerializeField] int damage = 10;
    [SerializeField] int currentAmmo = 6;
    [SerializeField] int currentReserveAmmo;
    [SerializeField] int maxAmmo = 6;
    [SerializeField] int maxReserveAmmo = 24;
    [Space]
    [SerializeField] float shootDelaySpeed = 0.2f;
    [SerializeField] float shootCooldown = 0.75f;
    AudioSource audioSource;
    [SerializeField] AudioClip shootSound, reloadSound, equipSound, shootEmptySound;

    InputManager inputManager;

    Rigidbody rb;

    [SerializeField] float bulletForce = 100;
    [SerializeField] float maxDistance = 100;

    bool reloading;

    int ammoToAdd;


    void Start()
    {
        inputManager = InputManager.Instance;
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    void Update()
    {

        if (inputManager.PlayerFireinput() && !reloading)
        {
            Shoot();
        }

        if (inputManager.PlayerReloadInput() && currentAmmo < maxAmmo && !reloading && currentReserveAmmo > 0)
        {
            Reload();
        }

        //Ammo
        if (currentAmmo > maxAmmo)
        {
            currentAmmo = maxAmmo;
        }
        if (currentAmmo < 0)
        {
            currentAmmo = 0;
        }

        if (currentReserveAmmo > maxReserveAmmo)
        {
            currentReserveAmmo = maxReserveAmmo;
        }
        if (currentReserveAmmo < 0)
        {
            currentReserveAmmo = 0;
        }
    }

    void Shoot()
    {
        if (currentAmmo > 0)
        {
            Debug.Log("Bang!");
            if (audioSource != null)
            {
                audioSource.PlayOneShot(shootSound);
            }
            currentAmmo--;
            //anim.Play("PistolShoot");
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance))
            {
                //if (hit.transform.tag == "Enemy")
                //{
                //    if (hit.transform.GetComponent<EnemyHealth>() != null)
                //    {
                //        eH = hit.transform.GetComponent<EnemyHealth>();
                //        eH.TakeDamage(damage);
                //    }
                //    else
                //    {
                //        eH = hit.transform.GetComponentInParent<EnemyHealth>();
                //        eH.TakeDamage(criticalDamage);
                //    }
                //}

                if (hit.transform.GetComponent<Rigidbody>() != null)
                {
                    rb = hit.transform.GetComponent<Rigidbody>();
                    rb.AddForce(transform.forward * bulletForce);
                }
            }
        }
        else
        {
            Debug.Log("no ammo");
            if (audioSource != null)
            {
                audioSource.PlayOneShot(shootEmptySound);
            }
        }
    }

    void Reload()
    {
        Debug.Log("Re-Goddamn-loading!");

        Debug.Log("reloading");

        ammoToAdd = maxAmmo - currentReserveAmmo;

        if (audioSource != null)
        {
            audioSource.PlayOneShot(reloadSound);
        }
        //StartCoroutine(Reloading());
        //anim.Play("PistolReload");
        reloading = true;

        if (currentReserveAmmo >= ammoToAdd)
        {
            currentAmmo = currentAmmo + ammoToAdd;
            currentReserveAmmo = currentReserveAmmo - ammoToAdd;
        }
        else
        {
            currentAmmo = currentAmmo + currentReserveAmmo;
            currentReserveAmmo = currentReserveAmmo - currentReserveAmmo;

        }
        reloading = false;

    }

    void GainAmmo(int amount)
    {
        currentReserveAmmo += amount;
    }


}
