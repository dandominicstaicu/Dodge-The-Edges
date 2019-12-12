using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
   {
        Application.LoadLevel("Nivel1");
   }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
    public void Difficulty()
    {
        Application.LoadLevel("Difficulty");
    }
    public void Levels()
    {
        Application.LoadLevel("Levels");
    }
    public void Level1()
    {
        Application.LoadLevel("Nivel1");
    }
    public void Level1e()
    {
        Application.LoadLevel("Nivel1e");
    }
    public void Level1m()
    {
        Application.LoadLevel("Nivel1m");
    }
    public void Level2()
    {
        Application.LoadLevel("Nivel2");
    }
    public void Level2e()
    {
        Application.LoadLevel("Nivel2e");
    }
    public void Level2m()
    {
        Application.LoadLevel("Nivel2m");
    }
    public void Level3()
    {
        Application.LoadLevel("Nivel3");
    }
    public void Level3e()
    {
        Application.LoadLevel("Nivel3e");
    }
    public void Level3m()
    {
        Application.LoadLevel("Nivel3m");
    }
    public void Level4()
    {
        Application.LoadLevel("Nivel4");
    }
    public void Level4e()
    {
        Application.LoadLevel("Nivel4e");
    }
    public void Level4m()
    {
        Application.LoadLevel("Nivel4m");
    }
    public void Level5()
    {
        Application.LoadLevel("Nivel5");
    }
    public void Level5e()
    {
        Application.LoadLevel("Nivel5e");
    }
    public void Level5m()
    {
        Application.LoadLevel("Nivel5m");
    }
    public void Meniu()
    {
        Application.LoadLevel("Menu");
    }
}
