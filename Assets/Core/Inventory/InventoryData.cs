using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventoryData
{
    public List<InventorySlot> Slots = new();

    public void AddItem(ItemData item, int amount = 1)
    {
        if (item.Stackable)
        {
            InventorySlot existing = Slots.Find(slot => slot.Item == item);
            if (existing != null)
            {
                existing.Amount += amount;
                return;
            }
        }

        Slots.Add(new InventorySlot(item, amount));
    }

    public void RemoveItem(ItemData item, int amount = 1)
    {
        InventorySlot slot = Slots.Find(s => s.Item == item);
        if (slot != null)
        {
            slot.Amount -= amount;
            if (slot.Amount <= 0) Slots.Remove(slot);
        }
    }
}
