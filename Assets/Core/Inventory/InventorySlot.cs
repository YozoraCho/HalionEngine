[System.Serializable]
public class InventorySlot
{
    public ItemData Item;
    public int Amount;

    public InventorySlot(ItemData item, int amount = 1)
    {
        Item = item;
        Amount = amount;
    }
}
