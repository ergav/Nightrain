using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickUp : MonoBehaviour
{

    [SerializeField] private GameObject tMPKeyPickUP;

    [HideInInspector]
    public bool keyIsTaken = false;
    private bool playerInArea = false;

    InputManager inputManager;
    Door door;

    void Start()
    {
        door = FindObjectOfType<Door>();
        inputManager = InputManager.Instance;
        tMPKeyPickUP.SetActive(false);
    }

    void Update()
    {
        if (playerInArea && inputManager.ActionInteract())
        {
            disableKey();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tMPKeyPickUP.SetActive(true);
            playerInArea = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {

        tMPKeyPickUP.SetActive(false);
        playerInArea = false;
    }

    private void disableKey()
    {
        tMPKeyPickUP.SetActive(false);
        Debug.Log("key is taken");
        keyIsTaken = true;
        door.playerHasKey = keyIsTaken;
        Destroy(gameObject);
    }
}
