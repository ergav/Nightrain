using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEditor;

[CreateAssetMenu(fileName = "Inventory", menuName = "Inventory/Inventory")]

public class Inventory : ScriptableObject/*, ISerializationCallbackReceiver*/
{
    public string savePath;
    public ItemDatabaseObject database;
    public InventoryData container;




    public void AddItem(Item _item, int _amount)
    {

        for (int i = 0; i < container.items.Count; i++)
        {
            if (container.items[i].item.Id == _item.Id && container.items[i].amount < container.items[i].item.stackLimit)
            {
                container.items[i].AddAmount(_amount);
                return;
            }
        }
        container.items.Add(new InventorySlot(_item.Id, _item, _amount));

    }

    [ContextMenu("Save")]
    public void Save()
    {
        string saveDate = JsonUtility.ToJson(this, true);
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(string.Concat(Application.persistentDataPath, savePath));
        bf.Serialize(file, saveDate);
        file.Close();
    }

    [ContextMenu("Load")]
    public void Load()
    {
        if (File.Exists(string.Concat(Application.persistentDataPath, savePath)))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(string.Concat(Application.persistentDataPath, savePath), FileMode.Open);
            JsonUtility.FromJsonOverwrite(bf.Deserialize(file).ToString(), this);
            file.Close();
        }
    }

    [ContextMenu("Clear")]
    public void Clear()
    {
        container = new InventoryData();
    }

    //public void OnAfterDeserialize()
    //{
    //    for (int i = 0; i < container.items.Count; i++)
    //    {
    //        container.items[i].item = database.getItem[container.items[i].ID];
    //    }
    //}

    //public void OnBeforeSerialize()
    //{

    //}
}

[System.Serializable]
public class InventoryData
{
    public List<InventorySlot> items = new List<InventorySlot>();

}

[System.Serializable]
public class InventorySlot
{
    public int ID;
    public Item item;
    public int amount;
    public InventorySlot(int _ID, Item _item, int _amount)
    {
        ID = _ID;
        item = _item;
        amount = _amount;
    }

    public void AddAmount(int value)
    {
        amount+=value;
    }
}
