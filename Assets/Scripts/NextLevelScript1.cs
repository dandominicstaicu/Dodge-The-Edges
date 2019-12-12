using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript1 : MonoBehaviour
{
    public GameObject nextLevelUI;
    public void Start()
    {
        SoundManagerScript.PlaySound("dead");
    }
    public void Restart()
    {
        Application.LoadLevel("Nivel2");
    }
    public void Levels()
    {
        Application.LoadLevel("Levels");
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
        Application.LoadLevel("Nivel3");
    }
    public void RestartE()
    {
        Application.LoadLevel("Nivel2e");
    }
    public void NextLevelE()
    {
        Application.LoadLevel("Nivel3e");
    }
    public void RestartM()
    {
        Application.LoadLevel("Nivel2m");
    }
    public void NextLevelM()
    {
        Application.LoadLevel("Nivel3m");
    }
}
