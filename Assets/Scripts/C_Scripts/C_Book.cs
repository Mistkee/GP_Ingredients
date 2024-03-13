using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Book : Interactive
{
    [SerializeField] private GameObject canvaRecipe;
    private bool interacted;
    public static C_Book instance;

    private void Awake()
    {
        instance = this;
    }
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
        canvaRecipe.SetActive(true);
        Time.timeScale = 0;
        interacted = true;
    }


    public bool InteractedWithBook()
    {
        return(interacted);
    }

}
