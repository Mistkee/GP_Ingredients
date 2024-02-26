using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_ChestScript : Interactive
{
    public GameObject item;
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        item.SetActive(false);
    }

    public override void OnInteraction()
    {
        animator.SetTrigger("Open");
        item.SetActive(true);
    }
}
