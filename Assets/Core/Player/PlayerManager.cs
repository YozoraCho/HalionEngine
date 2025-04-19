using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;

    public List<CharacterData> Characters = new();
    public CharacterData ActiveCharacter;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
    public void SwitchCharacter(int index)
    {
        if (index >= 0 && index < Characters.Count) ActiveCharacter = Characters[index];
    }

}
