using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public bool selectedCharacter = true;
    public GameObject spotLight;
    public Transform position1, position2;
    public void SwitchCharacter()
    {
        selectedCharacter = !selectedCharacter;
        if (selectedCharacter)
        {
            spotLight.transform.position = position1.position;
        }
        else
        {
            spotLight.transform.position = position2.position;
        }
        //Or easier : spotLight.transform.position = selectedCharacter?position1.position:position2.position;
    }

    public void GoToGame()
    {
        PlayerPrefs.SetInt("Character",selectedCharacter?0:1);
        SceneManager.LoadScene("Escape The Dungeon");
    }
    
}
