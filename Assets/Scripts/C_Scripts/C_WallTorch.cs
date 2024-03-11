using UnityEngine;
using UnityEngine.PlayerLoop;

public class C_WallTorch : Interactive
{
    public GameObject chest;
    public static int litTorchesCount = 0;
    [SerializeField] private int maxlitTorchesCount;

    private void Start()
    {
        chest.SetActive(false);
    }

    public override void OnInteraction()
    {
        //If I want to do the base OnInteraction anyway first
        //base.OnInteraction();
        //Activate light and fire
        litTorchesCount++;

        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(true);

        if(litTorchesCount == maxlitTorchesCount)
        {
            chest.SetActive(true);
        }

    }
}
