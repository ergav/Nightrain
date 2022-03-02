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
    [SerializeField] float shootCooldownTime = 0.75f;
    [SerializeField] float reloadTime = 1;
    AudioSource audioSource;
    [SerializeField] AudioClip shootSound, reloadSound, equipSound, shootEmptySound;

    InputManager inputManager;
    WeaponStats weaponStats;

    Rigidbody rb;

    [SerializeField] float bulletForce = 100;
    [SerializeField] float maxDistance = 100;

    bool reloading;
    bool shootCooldown;

    int ammoToAdd;


    void Start()
    {
        inputManager = InputManager.Instance;
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
            if (audioSource == null)
            {
                audioSource = GetComponentInParent<AudioSource>();
            }
        }

        weaponStats = GetComponentInParent<WeaponStats>();
    }

    float reloadTimer;
    float shootTimer;

    void Update()
    {

        if (inputManager.PlayerFireinput() && !reloading && !shootCooldown)
        {
            Shoot();
            shootCooldown = true;
        }

        if (inputManager.PlayerReloadInput() && currentAmmo < maxAmmo && !reloading && currentReserveAmmo > 0)
        {
            Reload();
        }


        if (reloading)
        {
            reloadTimer += Time.deltaTime;
            if (reloadTimer > reloadTime)
            {
                reloading = false;
                reloadTimer = 0;
            }
        }

        if (shootCooldown)
        {
            shootTimer += Time.deltaTime;
            if (shootTimer > shootCooldownTime)
            {
                shootCooldown = false;
                shootTimer = 0;
            }
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
            if (shootSound != null)
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
            if (shootEmptySound != null)
            {
                audioSource.PlayOneShot(shootEmptySound);
            }
        }
    }

    void Reload()
    {
        //Debug.Log("reloading");

        ammoToAdd = maxAmmo - currentAmmo;

        if (reloadSound != null)
        {
            audioSource.PlayOneShot(reloadSound);
        }
        //StartCoroutine(Reloading());
        //anim.Play("PistolReload");
        reloading = true;



        if (currentReserveAmmo >= ammoToAdd)
        {
            currentAmmo += ammoToAdd;
            currentReserveAmmo -= ammoToAdd;
        }
        else
        {
            currentAmmo += currentReserveAmmo;
            currentReserveAmmo -= currentReserveAmmo;
        }
        //reloading = false;

    }

    public void GainAmmo(int amount)
    {
        currentReserveAmmo += amount;
    }


}
