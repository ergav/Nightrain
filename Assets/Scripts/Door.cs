using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    InputManager inputManager;
    PlayerController player;
    Animator ator;

    private bool doorIsClosed = true;
    private bool doorCanBeOpen = false;
    private void Start()
    {
        inputManager = InputManager.Instance;
        player = FindObjectOfType<PlayerController>();
        ator = GetComponent<Animator>();
    }

    private void Update()
    {
        DoorInteraction();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Door is ready to be open");
            doorCanBeOpen = true;
            doorIsClosed = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("player left the are to open door");
            doorIsClosed = false;
            doorCanBeOpen = false;
        }
    }

    private void DoorInteraction()
    {
        if (doorIsClosed && doorCanBeOpen && inputManager.ActionInteract())
        {
            doorIsClosed = false;
            ator.SetBool("OpenDoor", true);
            ator.SetBool("CloseDoor", false);

        }
        else if (!doorIsClosed && doorCanBeOpen && inputManager.ActionInteract())
        {
            doorIsClosed = true;
            ator.SetBool("OpenDoor", false);
            ator.SetBool("CloseDoor", true);
        }
    }
}
