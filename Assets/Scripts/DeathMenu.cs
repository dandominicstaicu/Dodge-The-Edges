using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMenu : MonoBehaviour
{
    public GameObject deathMenuUI;

    // Start is called before the first frame update
    public void Respawn()
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
}
