using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {
    // Properties
    public string itemName;
    public int itemAmount;

    // Constructor
    public Item(string name, int amount) {
        this.itemName = name;
        this.itemAmount = amount;
    }
}
