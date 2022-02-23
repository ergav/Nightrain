using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Melee : MonoBehaviour
{
    [SerializeField] int damage = 10;
    [SerializeField] float swingCoolDown = 0.8f;

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip SwingSound, hitSound;
    InputManager inputManager;


    void Start()
    {
        inputManager = InputManager.Instance;
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    void Update()
    {
        if (inputManager.PlayerFireinput())
        {
            Swing();
        }
    }

    void Swing()
    {
        Debug.Log("Swoosh!");
    }
}
