using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Default Item", menuName = "Inventory/Default Item")]
public class DefaultItem : ItemObject
{
    private void Awake()
    {
        type = ItemType.Default;
    }

}
