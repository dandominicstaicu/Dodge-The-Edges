using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript : MonoBehaviour
{
    public GameObject nextLevelUI;
    public void Start()
    {
        SoundManagerScript.PlaySound("dead");
    }
    public void Restart()
    {
        Application.LoadLevel("Nivel1");
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
        Application.LoadLevel("Nivel2");
    }
    public void RestartE()
    {
        Application.LoadLevel("Nivel1e");
    }
    public void NextLevelE()
    {
        Application.LoadLevel("Nivel2e");
    }
    public void RestartM()
    {
        Application.LoadLevel("Nivel1m");
    }
    public void NextLevelM()
    {
        Application.LoadLevel("Nivel2m");
    }
}
