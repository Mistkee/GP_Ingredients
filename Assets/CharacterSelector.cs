using System.Collections.Generic;
using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    public List<GameObject> characters;
    void Start()
    {
        int playerChoice = 0;
        if (PlayerPrefs.HasKey("Character"))
        {
            playerChoice = PlayerPrefs.GetInt("Character");
        }

        characters[playerChoice].SetActive(true);
    }
}
