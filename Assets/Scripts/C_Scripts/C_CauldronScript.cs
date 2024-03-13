using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Cauldron : Interactive
{
    [SerializeField] KeyItemData item;
    public override void OnInteraction()
    {
        foreach (KeyItemData item in requiredItems)
        {
            Inventory.Instance.RemoveFromInventory(item);
        }
        //GetComponent<Animator>().SetTrigger("Potion") ;
        Inventory.Instance.PickupKeyItem(item);
        
    }
}
