using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour
{
    [SerializeField] private float healAmount;
    [SerializeField] private float rotationSpeed;

    private InputManager inputManager;

    private HealthSystem hs;
    // Start is called before the first frame update
    void Start()
    {
        hs = FindObjectOfType<HealthSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        hs.RestoreHealth(healAmount);
        Destroy(gameObject);
    }
}
