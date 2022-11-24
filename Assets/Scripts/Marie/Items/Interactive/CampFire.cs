using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampFire : Interactive
{
    public KeyItemData litTorch;
    public override void OnInteraction()
    {
        //If I want to do the base OnInteraction anyway first
        //
        //Remove UNLIT_TORCH from inventory
        //In addition, add LIT_TORCH to found objects
        Inventory.Instance.RemoveFromInventory(requiredItems[0]);
        Inventory.Instance.PickupKeyItem(litTorch);
    }
}
