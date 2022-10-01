﻿using System;
using System.Collections.Generic;

public static class InventoryData
{
    private static readonly Dictionary<ItemType, bool> pickedItems;

    static InventoryData()
    {
        pickedItems = new();

        var values = (ItemType[])Enum.GetValues(typeof(ItemType));
        foreach (var t in values)
        {
            pickedItems.Add(t, false);
        }
    }
    
    public static void AddItem(ItemType itemType)
    {
        pickedItems[itemType] = true;
    } 
    public static void RemoveItem(ItemType itemType)
    {
        pickedItems[itemType] = false;
    }
}