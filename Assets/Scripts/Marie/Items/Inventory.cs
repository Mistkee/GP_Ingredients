using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;
    
    private List<KeyItemData> _foundKeys = new List<KeyItemData>();
    [SerializeField] private List<KeyItem> usableItems;
    [SerializeField] private Transform hand;

    private int objectInHand = -1;

    private void Start()
    {
        Instance = this;
    }

    public void RemoveFromInventory(KeyItemData keyItem)
    {
        if (_foundKeys.Contains(keyItem))
        {
            _foundKeys.Remove(keyItem);
            int place = FindItemInList(keyItem.ID);
            if (place != -1)
            {
                KeyItem key = usableItems[place];
                usableItems.RemoveAt(place);
                Destroy(key.gameObject);
            }
        }
    }
    public void PickupKeyItem(KeyItemData keyItem)
    {
        if (!_foundKeys.Contains(keyItem))
        {
            GameObject keyInstance = Instantiate(keyItem.prefab, hand);
            _foundKeys.Add(keyItem);
            usableItems.Add(keyInstance.GetComponent<KeyItem>());
            //Utilise le dernier trouvé
            HoldItem(usableItems.Count-1);
        }
    }

    private int FindItemInList(string id)
    {
        for (int item = 0; item < usableItems.Count; item++)
        {
            if (usableItems[item].GetComponent<KeyItem>().data.ID == id)
            {
                return item;
            }
        }
        
        //Easier method would be
        //return usableItems.FindIndex(item => item.GetComponent<KeyItem>()?.ID == id);

        return -1;
    }

    private void HoldItem(int number)
    {
        if (number < -1 || number >= usableItems.Count)
        {
            //Index out of bounds, nothing can be done
            return;
        }
        if (objectInHand != -1)
        {
            usableItems[objectInHand].gameObject.SetActive(false);
        }

        objectInHand = number;
        usableItems[objectInHand].gameObject.SetActive(true);
    }

    public void NextItem()
    {
        if (usableItems.Count != 0)
        {
            int next = ((objectInHand+1)%usableItems.Count)-1;
            HoldItem(next);
        }
    }

    public bool IsItemFound(KeyItemData key)
    {
        //Empty ID means no necessary key item
        //true if the id is found in the list, false otherwise
        return key==null|| _foundKeys.Contains(key);
    }

    public bool HasEveryItem(List<KeyItemData> keys)
    {
        foreach (KeyItemData key in keys)
        {
            if (!IsItemFound(key))
            {
                return false;
            }
        }

        return true;
    }
}
