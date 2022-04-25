using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public Inventory inventory;

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
