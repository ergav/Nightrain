using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayInventory : MonoBehaviour
{
    public Inventory inventory;
    public GridLayoutGroup gridLayout;
    public int xStart, yStart;
    //public RectTransform[] inventorySlots;
    bool fullInventory;

    Dictionary<InventorySlot, GameObject> itemdisplayed = new Dictionary<InventorySlot, GameObject>();

    void Start()
    {
        gridLayout = GetComponent<GridLayoutGroup>();
        //inventorySlots = GetComponentsInChildren<RectTransform>();
        CreateDisplay();

    }

    void Update()
    {
        UpdateDisplay();
    }

    public void CreateDisplay()
    {
        for (int i = 0; i < inventory.container.Count; i++)
        {
            var obj = Instantiate(inventory.container[i].item.prefab, Vector3.zero, Quaternion.identity, transform);
            //obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
            
        }
    }

    public void UpdateDisplay()
    {
        for (int i = 0; i < inventory.container.Count; i++)
        {
            if (itemdisplayed.ContainsKey(inventory.container[i]))
            {

            }
            else
            {
                var obj = Instantiate(inventory.container[i].item.prefab, Vector3.zero, Quaternion.identity, transform);
                itemdisplayed.Add(inventory.container[i], obj);
            }
        }
    }

    //public Vector3 GetPosition(int i)
    //{
    //    return new Vector3(xStart + (gridLayout.spacing.x) * (i % gridLayout.constraintCount), (yStart + (-gridLayout.spacing.y) * (i / gridLayout.constraintCount)), 0f);
    //}

    //public void AddItem(GameObject item)
    //{
    //    for (int i = 0; i < inventorySlots.Length; i++)
    //    {
    //        if (!inventorySlots[i].hasItem)
    //        {
    //            GameObject addedItem = Instantiate(item);
    //            addedItem.transform.SetParent(inventorySlots[i].transform);
    //            RectTransform itemTransform = addedItem.GetComponent<RectTransform>();
    //            itemTransform.anchoredPosition = new Vector2(0, 0);
    //            return;
    //        }
    //    }
    //}
}
