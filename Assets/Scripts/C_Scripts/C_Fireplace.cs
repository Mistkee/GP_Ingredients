using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Fireplace : Interactive
{
    [SerializeField] GameObject fireplaceCauldron;
    public override void OnInteraction()
    {
        Inventory.Instance.RemoveFromInventory(requiredItems[0]);
        fireplaceCauldron.SetActive(true);
    }
}
