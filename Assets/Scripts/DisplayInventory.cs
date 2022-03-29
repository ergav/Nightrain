using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInventory : MonoBehaviour
{
    Inventory inventory;
    GridLayout gridLayout;
    public inventorySlot[] inventorySlots;

    void Start()
    {
        gridLayout = GetComponentInChildren<GridLayout>();
        inventorySlots = GetComponentsInChildren<inventorySlot>();
    }

    void Update()
    {
        
    }
}
