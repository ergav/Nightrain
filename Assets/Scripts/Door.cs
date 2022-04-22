using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private KeyPickUp key;
    [SerializeField] private GameObject tmpOpenDoor;

    InputManager inputManager;
    PlayerController player;
    Animator ator;

    [HideInInspector]
    public bool playerHasKey = false;
    private bool doorIsClosed = true;
    private bool doorCanBeOpen = false;
    private void Start()
    {
        inputManager = InputManager.Instance;
        player = FindObjectOfType<PlayerController>();
        ator = GetComponent<Animator>();

        tmpOpenDoor.SetActive(false);
        playerHasKey = false;
    }

    private void Update()
    {
        DoorInteraction();
        Debug.Log(playerHasKey);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tmpOpenDoor.SetActive(true);
            doorCanBeOpen = true;
            doorIsClosed = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tmpOpenDoor.SetActive(false);
            doorIsClosed = false;
            doorCanBeOpen = false;
        }
    }

    private void DoorInteraction()
    {
        if (doorIsClosed && doorCanBeOpen && inputManager.ActionInteract() && playerHasKey)
        {
            doorIsClosed = false;
            ator.SetBool("OpenDoor", true);
            ator.SetBool("CloseDoor", false);

        }
        else if (!doorIsClosed && doorCanBeOpen && inputManager.ActionInteract() && playerHasKey)
        {
            doorIsClosed = true;
            ator.SetBool("OpenDoor", false);
            ator.SetBool("CloseDoor", true);
        }
    }
}
