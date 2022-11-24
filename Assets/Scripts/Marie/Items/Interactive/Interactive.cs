using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactive : MonoBehaviour
{
    public InteractionType interactionType = InteractionType.PushButton;
    
    public bool onlyOnce = true;

    [Header("Condition")] 
    public List<KeyItemData> requiredItems;

    public bool waitForObject;
    
    //Basic behaviour for Interactive objects is to trigger an animation
    //virtual makes the function changeable in children classes
    public virtual void OnInteraction()
    {
        Debug.LogWarning("This interaction has not been coded yet !");
    }

    
}
