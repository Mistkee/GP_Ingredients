using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class C_DoorLock : Interactive
{
    [SerializeField] KeyItemData key, beaker;
    Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public override void OnInteraction()
    {
        if (Inventory.Instance.IsItemFound(beaker))
        {
            animator.SetTrigger("OpenDoor");
        }
        else if (Inventory.Instance.IsItemFound(key))
        {
            if(key != null)
            {
                Inventory.Instance.RemoveFromInventory(key);
                Debug.Log("The key broke");
            }
        }
    }
}
