using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Pistol : MonoBehaviour
{
    [SerializeField] int damage = 10;
    //[SerializeField] int weaponStats.currentRevolverAmmo = 6;
    //[SerializeField] int weaponStats.currentRevolverReserveAmmo;
    //[SerializeField] int weaponStats.maxRevolverAmmo = 6;
    //[SerializeField] int weaponStats.maxRevolverReserveAmmo = 24;
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

        if (inputManager.PlayerReloadInput() && weaponStats.currentRevolverAmmo < weaponStats.maxRevolverAmmo && !reloading && weaponStats.currentRevolverReserveAmmo > 0)
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
        if (weaponStats.currentRevolverAmmo > weaponStats.maxRevolverAmmo)
        {
            weaponStats.currentRevolverAmmo = weaponStats.maxRevolverAmmo;
        }
        if (weaponStats.currentRevolverAmmo < 0)
        {
            weaponStats.currentRevolverAmmo = 0;
        }

        if (weaponStats.currentRevolverReserveAmmo > weaponStats.maxRevolverReserveAmmo)
        {
            weaponStats.currentRevolverReserveAmmo = weaponStats.maxRevolverReserveAmmo;
        }
        if (weaponStats.currentRevolverReserveAmmo < 0)
        {
            weaponStats.currentRevolverReserveAmmo = 0;
        }
    }

    void Shoot()
    {
        if (weaponStats.currentRevolverAmmo > 0)
        {
            Debug.Log("Bang!");
            if (shootSound != null)
            {
                audioSource.PlayOneShot(shootSound);
            }
            weaponStats.currentRevolverAmmo--;
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

        ammoToAdd = weaponStats.maxRevolverAmmo - weaponStats.currentRevolverAmmo;

        if (reloadSound != null)
        {
            audioSource.PlayOneShot(reloadSound);
        }
        //StartCoroutine(Reloading());
        //anim.Play("PistolReload");
        reloading = true;



        if (weaponStats.currentRevolverReserveAmmo >= ammoToAdd)
        {
            weaponStats.currentRevolverAmmo += ammoToAdd;
            weaponStats.currentRevolverReserveAmmo -= ammoToAdd;
        }
        else
        {
            weaponStats.currentRevolverAmmo += weaponStats.currentRevolverReserveAmmo;
            weaponStats.currentRevolverReserveAmmo -= weaponStats.currentRevolverReserveAmmo;
        }
        //reloading = false;

    }

    //public void GainAmmo(int amount)
    //{
    //    weaponStats.currentRevolverReserveAmmo += amount;
    //}


}
