using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowPersonSpawner : MonoBehaviour
{

    [SerializeField] private Transform targetSpawnLocation;
    [SerializeField] GameObject prefab;

    PlayerController player;

    void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(prefab, targetSpawnLocation);
            Destroy(gameObject);
        }
    }
}
