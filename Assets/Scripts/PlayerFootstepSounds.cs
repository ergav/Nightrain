using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFootstepSounds : MonoBehaviour
{
    PlayerController playerController;
    AudioSource audioSource;
    [SerializeField] AudioClip[] metalSounds, woodSounds, carpetSounds;
    [SerializeField] float walkSoundRate = 0.75f, runSoundRate = 0.25f;
    float soundRate;
    int rng;

    public bool moving;
    public bool sprinting;

    void Start()
    {
        playerController = GetComponent<PlayerController>();
        audioSource = GetComponentInChildren<AudioSource>();
    }

    float timer;
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 3))
        {

        }

        if (moving)
        {
            timer += Time.deltaTime;
            if (timer > soundRate)
            {
                rng = Random.Range(0, woodSounds.Length);
                audioSource.PlayOneShot(woodSounds[rng]);
                timer = 0;
            }
        }

        if (sprinting)
        {
            soundRate = runSoundRate;
        }
        else
        {
            soundRate = walkSoundRate;
        }


    }



}
