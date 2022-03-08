using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFootstepSounds : MonoBehaviour
{
    PlayerController playerController;
    AudioSource audioSource;
    [SerializeField] AudioSource[] metalSounds, woodSounds, carpetSounds;
    [SerializeField] float walkSoundRate = 0.75f, runSoundRate = 0.25f;
    int rng;

    void Start()
    {
        playerController = GetComponent<PlayerController>();
        audioSource = GetComponentInChildren<AudioSource>();
    }

    void Update()
    {
        
    }
}
