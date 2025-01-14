using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_LockedKeyItem : KeyItem
{
    private SphereCollider collider;

    private void Start()
    {
        collider = GetComponent<SphereCollider>();
        collider.enabled = false;
    }

    private void Update()
    {
        if(C_Book.instance.InteractedWithBook())
        {
            collider.enabled = true;
        }
    }

}
