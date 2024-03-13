using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Door_Beaker : Interactive
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
