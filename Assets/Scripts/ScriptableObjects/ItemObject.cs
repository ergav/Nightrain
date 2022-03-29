using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Health, Ammo, Weapon, Default
}

public abstract class ItemObject : ScriptableObject
{
    public GameObject prefab;
    public ItemType type;
    public Vector2 slotsCovered = new Vector2(1,1);
    [TextArea(10, 15)]public string ItemDescription;
}
