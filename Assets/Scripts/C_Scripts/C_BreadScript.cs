using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_BreadScript : Interactive
{
    [SerializeField] GameObject halfBread1, halfBread2;
    private SphereCollider collider;

    private void Start()
    {
        collider = GetComponent<SphereCollider>();
        collider.enabled = false;

        halfBread1.SetActive(false);
        halfBread2.SetActive(false);
    }

    private void Update()
    {
        if (C_Book.instance.InteractedWithBook())
        {
            collider.enabled = true;
        }
    }

    public override void OnInteraction()
    {
        halfBread1.SetActive(true); 
        halfBread2.SetActive(true);

        Inventory.Instance.RemoveFromInventory(requiredItems[0]);

        Destroy(gameObject);
    }
}
