using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowPersonSpawner : MonoBehaviour
{

    [SerializeField] private Transform targetSpawnLocation;
    [SerializeField] GameObject prefab;

    public float minDistanceDespawn;
    public float speed;

    private bool vFXPlayed = false;

    private GameObject prefabInstance;

    PlayerController player;
    AudioSource aSource;

    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        aSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (vFXPlayed)
        {
            Mathf.Lerp(1, 0.1f, aSource.volume * speed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !prefabInstance)
        {
            if (!vFXPlayed) aSource.Play();
            prefabInstance = Instantiate(prefab, targetSpawnLocation);
            Destroy(gameObject, 10f);
            vFXPlayed = true;
        }
    }
}
