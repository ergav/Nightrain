using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : MonoBehaviour
{
    [SerializeField] private float damageAmount;

    private HealthSystem hs;
    // Start is called before the first frame update
    void Start()
    {
        hs = FindObjectOfType<HealthSystem>();
    }

    

    private void OnTriggerEnter(Collider other)
    {
        hs.TakeDamage(damageAmount);
        Destroy(gameObject);
    }
}
