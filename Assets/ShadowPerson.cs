using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowPerson : MonoBehaviour
{
    [Tooltip("Minimum distance of how close can the player get close before ShadowPerson disapears")]
    [SerializeField] private float minDistanceToDespawn;

    [SerializeField] private ParticleSystem ps;

    [SerializeField] AudioClip[] audioClips;

    private float distanceToPlayer;

    PlayerController player;
    AudioSource audioSource;
    ShadowPersonSpawner spawner;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        player = FindObjectOfType<PlayerController>();
        spawner = FindObjectOfType<ShadowPersonSpawner>();

        minDistanceToDespawn = spawner.minDistanceDespawn;
    }

    void Update()
    {
        if (audioSource.clip == null)
        {
            audioSource.Play();
        }
        
        distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        
        if (distanceToPlayer <= minDistanceToDespawn)
        {
            Destroy(gameObject);
        }else
        {
            Destroy(gameObject, 20f);
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, minDistanceToDespawn);
    }
}
