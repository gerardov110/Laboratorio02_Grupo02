using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Inventory
{
    private List<IInventoryItem> items = new List<IInventoryItem>();

    public void AddItem(IInventoryItem item)
    {
        items.Add(item);
    }

    public void UseItem(string itemName)
    {
        var item = items.FirstOrDefault(i => i.Name == itemName);
        item?.Use();
    }
}
