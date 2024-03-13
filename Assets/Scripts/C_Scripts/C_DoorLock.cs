using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class C_DoorLock : Interactive
{
    public override void OnInteraction()
    {
        //BREAK KEY
        Inventory.Instance.RemoveFromInventory(requiredItems[0]);
        Debug.Log("The key broke");
    }
}
