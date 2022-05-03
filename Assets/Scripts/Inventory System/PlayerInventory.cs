using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public Inventory inventory;

    public GameObject inventoryUI;

    InputManager inputManager;

    PlayerCamera playerCamera;

    bool inventoryIsOpen;

    private void Start()
    {
        inputManager = InputManager.Instance;
        playerCamera = GetComponentInChildren<PlayerCamera>();

        if (inventoryUI == null)
        {
            inventoryUI = GameObject.Find("Inventory UI");
        }
    }

    private void Update()
    {
        if (inputManager.ToggleInventory())
        {
            inventoryIsOpen = !inventoryIsOpen;
        }

        if (inventoryIsOpen)
        {
            inventoryUI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            playerCamera.enabled = false;
        }
        else
        {
            inventoryUI.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            playerCamera.enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        var item = other.GetComponent<GroundItem>();
        if (item)
        {
            inventory.AddItem(new Item( item.itemObject), 1);
            Destroy(other.gameObject);
        }

    }

    private void OnApplicationQuit()
    {
        inventory.container.items.Clear();
    }
}