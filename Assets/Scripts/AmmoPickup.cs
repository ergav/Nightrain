using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] int ammoToAdd = 6;
    GameObject pistolTransform;
    public Pistol pistol;

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
            pistolTransform = other.GetComponentInChildren<Pistol>().gameObject;
            pistol = pistolTransform.GetComponent<Pistol>();
            pistol.GainAmmo(ammoToAdd);
            Destroy(gameObject);
        }
    }
}
