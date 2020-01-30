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
    public void Levels()
    {
        Application.LoadLevel("Levels");
    }
    public void Level1()
    {
        Application.LoadLevel("Nivel1");
    }
    public void Level2()
    {
        Application.LoadLevel("Nivel2");
    }
    public void Level3()
    {
        Application.LoadLevel("Nivel3");
    }
    public void Level4()
    {
        Application.LoadLevel("Nivel4");
    }
    public void Level5()
    {
        Application.LoadLevel("Nivel5");
    }
    public void Level6()
    {
        Application.LoadLevel("Nivel6");
    }
    public void Level7()
    {
        Application.LoadLevel("Nivel7"); 
    }
    public void Meniu()
    {
        Application.LoadLevel("Menu");
    }
}
