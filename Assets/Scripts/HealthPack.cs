using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour
{
    [SerializeField] private float healAmount;

    private HealthSystem hs;
    // Start is called before the first frame update
    void Start()
    {
        hs = FindObjectOfType<HealthSystem>();
    }

    // Update is called once per frame





    private void OnTriggerEnter(Collider other)
    {
        hs.RestoreHealth(healAmount);
        Destroy(gameObject);
    }
}
