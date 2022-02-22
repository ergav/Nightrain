using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinAndLose : MonoBehaviour
{
    [SerializeField] private CanvasGroup _HUD_CanvasGroup;
    [SerializeField] private GameObject deathScreen;

    private HealthSystem hs;

    
    private void Awake()
    {
        hs = FindObjectOfType<HealthSystem>();
    }

    public void GameLost()
    {
        deathScreen.gameObject.SetActive(true);

        Debug.Log("You lost!");
        _HUD_CanvasGroup.alpha = 0;
        _HUD_CanvasGroup.interactable = false;
        _HUD_CanvasGroup.blocksRaycasts = false;

        Time.timeScale = 0;
    }

    public void GameWon()
    {
        // you have won the game.
        // credits scene 
    }

    public void GameRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ExitToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("Don't leave me!!!");
        Application.Quit();
    }
}
