using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Cauldron : Interactive
{
    [SerializeField] KeyItemData item;
    public override void OnInteraction()
    {
        //GetComponent<Animator>().SetTrigger("Potion") ;
        Inventory.Instance.PickupKeyItem(item);
    }
}
