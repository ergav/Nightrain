using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public Inventory inventory;

    public GameObject inventoryUI;

    InputManager inputManager;

    bool inventoryIsOpen;

    private void Start()
    {
        inputManager = InputManager.Instance;

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
        }
        else
        {
            inventoryUI.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        var item = other.GetComponent<Item>();
        if (item)
        {
            inventory.AddItem(item.itemObject, 1);
            Destroy(other.gameObject);
        }

    }

    private void OnApplicationQuit()
    {
        inventory.container.Clear();
    }
}