using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

    // Define the list to store the items
    private List<Item> inventory = new List<Item>();

    private void Start() {
        // Add items to the inventory
        AddItem("Coin", 5);
        AddItem("Health Potion", 3);
        AddItem("Key", 2);

        // Display the inventory
        DisplayInventory();
    }

    // Method to add an item to the inventory
    public void AddItem(string itemName, int amount) {
        // Check if the item already exists in the inventory
        Item existingItem = inventory.Find(item => item.itemName == itemName);

        // If the item already exists, increase its amount else add a new item
        if (existingItem != null) {
            existingItem.itemAmount += amount;
        } else {
            Item newItem = new Item(itemName, amount);
            inventory.Add(newItem);
        }
    }

    // Method to display the inventory
    public void DisplayInventory() {
        Debug.Log("Inventory Contents:");

        // Loop through the inventory and display each item
        foreach (Item item in inventory) {
            Debug.Log($"{item.itemName}: {item.itemAmount}");
        }
    }
}
