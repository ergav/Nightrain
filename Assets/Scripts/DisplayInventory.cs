using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInventory : MonoBehaviour
{
    Inventory inventory;
    GridLayout gridLayout;
    public inventorySlot[] inventorySlots;
    bool fullInventory;

    void Start()
    {
        gridLayout = GetComponentInChildren<GridLayout>();
        inventorySlots = GetComponentsInChildren<inventorySlot>();
    }

    void Update()
    {
        
    }

    public void AddItem(GameObject item)
    {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            if (!inventorySlots[i].hasItem)
            {
                GameObject addedItem = Instantiate(item);
                addedItem.transform.SetParent(inventorySlots[i].transform);
                addedItem.transform.position = Vector3.zero;
                return;
            }
        }
    }
}
