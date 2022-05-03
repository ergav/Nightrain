using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ItemType
{
    Health, Ammo, Weapon, Default
}

//[CreateAssetMenu(fileName = "InventorySlot", menuName = "Inventory/InventorySlot")]
public abstract class ItemObject : ScriptableObject
{
    public int Id;
    public Sprite uiDisplay;
    public int stackLimit = 1;
    public ItemType type;
    public Vector2 slotsCovered = new Vector2(1,1);
    [TextArea(10, 15)]public string ItemDescription;
}

[System.Serializable]
public class Item
{
    public string name;
    public int Id;
    public int stackLimit;
    public Item(ItemObject item)
    {
        name = item.name;
        Id = item.Id;
        stackLimit = item.stackLimit;
    }
}
