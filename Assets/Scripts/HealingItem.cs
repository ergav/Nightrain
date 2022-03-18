using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Healing Item", menuName = "Inventory/Healing Item")]
public class HealingItem : ItemObject
{
    public int amountToHeal;
    private void Awake()
    {
        type = ItemType.Health;
    }
}
