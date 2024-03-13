using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Fireplace : Interactive
{
    PlayerInteractionAnim anim;
    [SerializeField] GameObject fireplaceCauldron, fire;
    [SerializeField] KeyItemData torch, cauldron;
    bool fireOn, cauldronOn;

    private void Start()
    {
        anim = GetComponent<PlayerInteractionAnim>();
    }
    public override void OnInteraction()
    {
        if(Inventory.Instance.IsItemFound(torch))
        {
            fire.SetActive(true);
            fireOn = true;
            Inventory.Instance.RemoveFromInventory(torch);

        }
        
        if (Inventory.Instance.IsItemFound(cauldron))
        {
            fireplaceCauldron.SetActive(true);
            cauldronOn = true;
            Inventory.Instance.RemoveFromInventory(cauldron);
        }

        if(fireOn && cauldronOn)
        {
            GetComponent<SphereCollider>().enabled = false;
            fireplaceCauldron.GetComponent<SphereCollider>().enabled = true;
        }

    }
}
