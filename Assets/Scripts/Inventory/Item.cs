using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public string itemName;
    public int itemAmount;

    public Item(string name, int amount) {
        this.itemName = name;
        this.itemAmount = amount;
    }
}
