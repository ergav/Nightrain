using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] int ammoToAdd = 6;
    public WeaponStats weaponStats;
    [SerializeField] AudioClip pickupSound;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            weaponStats = other.GetComponent<WeaponStats>();
            weaponStats.GainRevolverAmmo(ammoToAdd);
            AudioSource source = other.GetComponentInChildren<AudioSource>();
            if (source != null)
            {
                source.PlayOneShot(pickupSound);
            }

            Destroy(gameObject);
        }
    }
}
