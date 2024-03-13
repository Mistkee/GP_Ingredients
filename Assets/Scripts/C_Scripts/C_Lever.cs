using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Lever : Interactive
{
    [SerializeField] GameObject bookShelf;
    private void Update()
    {
        //if (C_Book.instance.InteractedWithBook())
        //{
        //    GetComponent<Collider>().enabled = true;
        //}
    }
    public override void OnInteraction()
    {
        //GetComponent<Animator>().SetTrigger("Interacted");
        bookShelf.GetComponent<Animator>().SetTrigger("Open");
    }
}
