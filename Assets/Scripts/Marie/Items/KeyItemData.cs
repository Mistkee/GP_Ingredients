using UnityEngine;

[CreateAssetMenu(menuName = "Dungeon/Key")]
public class KeyItemData : ScriptableObject
{
    public string ID;
    public Sprite icon;
    public GameObject prefab;
    //Allow the player to hold more than one item of the same ID
    public bool allowDuplicates = false;
}
