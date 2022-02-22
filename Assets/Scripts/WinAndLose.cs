using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinAndLose : MonoBehaviour
{
    private HealthSystem hs;

    private void Awake()
    {
        hs = FindObjectOfType<HealthSystem>();
    }

    public void GameLost()
    {
        //UI appears
        // time.scale = 0

    }

    public void GameWon()
    {
        // you have won the game.
        // credits scene 
    }

    public void GameRestart()
    {

    }

    public void ExitToMainMenu()
    {

    }

    public void QuitGame()
    {
        Debug.Log("Don't leave me!!!");
        Application.Quit();
    }
}
