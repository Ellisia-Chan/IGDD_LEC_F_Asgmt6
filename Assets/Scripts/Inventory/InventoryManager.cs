using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {
    private List<Item> inventory = new List<Item>();

    private void Start() {
        AddItem("Coin", 5);
        AddItem("Health Potion", 3);
        AddItem("Key", 2);

        DisplayInventory();
    }

    public void AddItem(string itemName, int amount) {
        Item existingItem = inventory.Find(item => item.itemName == itemName);

        if (existingItem != null) {
            existingItem.itemAmount += amount;
        } else {
            Item newItem = new Item(itemName, amount);
            inventory.Add(newItem);
        }
    }

    public void DisplayInventory() {
        Debug.Log("Inventory Contents:");

        foreach (Item item in inventory) {
            Debug.Log($"{item.itemName}: {item.itemAmount}");
        }
    }
}
