using UnityEngine;

public abstract class ItemData : ScriptableObject
{
    public string ItemName;
    public Sprite Icon;
    public bool Stackable = true;

    public virtual void Use(CharacterData character)
    {
        Debug.Log($"{ItemName} used by {character.CharacterName}.");
    }
}
