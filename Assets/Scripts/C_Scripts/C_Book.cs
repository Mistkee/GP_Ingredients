using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Book : Interactive
{
    [SerializeField] private GameObject canvaRecipe;
    //private bool isInRange;

    private void Start()
    {
        canvaRecipe.SetActive(false);
    }
    private void Update()
    {
        if (canvaRecipe.activeSelf == true && Input.GetKey(KeyCode.Escape))
        {
            canvaRecipe.SetActive(false);
            Time.timeScale = 1.0f;
        }
    }

    public override void OnInteraction()
    {
        Debug.Log("dsfsdf");
        canvaRecipe.SetActive(true);
        Time.timeScale = 0;
    }


    //private void OnTriggerEnter(Collider other)
    //{

    //    //uiInteractive.SetActive(true);
    //    //isInRange = true;
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    uiInteractive.SetActive(false);
    //    isInRange = false;
    //}

}
