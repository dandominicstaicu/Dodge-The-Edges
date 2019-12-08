using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript3 : MonoBehaviour
{
    public GameObject nextLevelUI;

    // Start is called before the first frame update
    public void Restart()
    {
        Application.LoadLevel("Nivel4");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void MainMenu()
    {
        Application.LoadLevel("Menu");
    }

    public void NextLevel()
    {
        Application.LoadLevel(5);
    }
}
