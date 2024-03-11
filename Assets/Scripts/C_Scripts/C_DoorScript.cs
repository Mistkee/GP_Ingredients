using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_DoorScript : Interactive
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public override void OnInteraction()
    {
        animator.SetTrigger("OpenDoor");
    }
}
