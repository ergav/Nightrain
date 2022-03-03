using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] int ammoToAdd = 6;
    public WeaponStats weaponStats;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            weaponStats = other.GetComponent<WeaponStats>();
            weaponStats.GainRevolverAmmo(ammoToAdd);
            Destroy(gameObject);
        }
    }
}
