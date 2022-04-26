using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTest : MonoBehaviour
{
    public GameObject inventoryObject;
    DisplayInventory displayInventory;
    ItemObject itemObject;

    void Start()
    {
        displayInventory = GameObject.FindObjectOfType<DisplayInventory>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "Player")
        //{
        //    displayInventory.AddItem(inventoryObject);
        //    Destroy(gameObject);
        //}
    }
}
