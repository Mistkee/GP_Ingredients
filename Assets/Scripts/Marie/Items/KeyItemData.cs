using UnityEngine;

[CreateAssetMenu(menuName = "Dungeon/Key")]
public class KeyItemData : ScriptableObject
{
    public string ID;
    public Sprite icon;
    public GameObject prefab;
}
