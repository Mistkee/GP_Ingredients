using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum InteractionType
{
    None,
    OpenDoor,
    PushButton,
    OpenChest,
    FailedAction,
    Pickup
}

public class PlayerInteractionAnim : MonoBehaviour
{
    private Animator _animator;

    public static bool AnimationInProgress = false;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void BeginAnimation()
    {
        AnimationInProgress = true;
    }

    public void EndAnimation()
    {
        AnimationInProgress = false;
    }

    public bool PlayAnimation(InteractionType animation)
    {
        //if an animation is already in progress or we are trying to do something while walking
        if (AnimationInProgress || _animator.GetFloat("Speed") > 1) return false;
        switch (animation)
        {
            case InteractionType.OpenDoor:
            {
                _animator.SetTrigger("Open Door");
                break;
            }
            case InteractionType.PushButton:
            {
                _animator.SetTrigger("Push Button");
                break;
            }
            case InteractionType.OpenChest:
            {
                _animator.SetTrigger("Open Chest");
                break;
            }
            case InteractionType.FailedAction:
            {
                _animator.SetTrigger("Failed");
                break;
            }
            case InteractionType.Pickup:
            {
                _animator.SetTrigger("Pickup");
                break;
            }
        }

        return false;
    }
}
