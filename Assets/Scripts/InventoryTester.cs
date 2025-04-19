using UnityEngine;

public class InventoryTester : MonoBehaviour
{
    public ItemData testItem;

    private void Start()
    {
        if (PlayerManager.Instance == null || PlayerManager.Instance.ActiveCharacter == null)
        {
            Debug.LogWarning("No active character to test inventory.");
            return;
        }

        PlayerManager.Instance.ActiveCharacter.Inventory.AddItem(testItem, 2);
        Debug.Log($"Added 2x {testItem.ItemName} to {PlayerManager.Instance.ActiveCharacter.CharacterName}'s inventory.");
    }
}
