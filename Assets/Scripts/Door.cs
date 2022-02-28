using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    PlayerController player;
    Animator ator;

    private bool doorIsOpen = false;
    private void Start()
    {
        player = FindObjectOfType<PlayerController>();
        ator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !doorIsOpen)
        {
            ator.Play("Door_Open");
            doorIsOpen = true;
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && doorIsOpen)
        {
            ator.Play("Door_Close");
            doorIsOpen = false;

        }
    }
}
