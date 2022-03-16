using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Animations;

public class WinAndLose : MonoBehaviour
{
    [SerializeField] private CanvasGroup _HUD_CanvasGroup;
    [SerializeField] private GameObject deathScreen;

    [SerializeField] private Animator animator;
    
    private HealthSystem hs;


    private void Awake()
    {

        hs = FindObjectOfType<HealthSystem>();

    }

    private void Start()
    {
        animator.SetBool("fadeIn", false);
    }

    public void GameLost()
    {
        animator.SetBool("fadeIn", true);
        deathScreen.gameObject.SetActive(true);

        Debug.Log("You lost!");
        hideHUD();

        Time.timeScale = 0;
    }

    public void GameWon()
    {
        animator.SetBool("fadeIn", true);
        //hideHUD();
    }

    public void GameRestart()
    {
        Time.timeScale = 1;
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

    public void hideHUD()
    {
        _HUD_CanvasGroup.alpha = 0;
        _HUD_CanvasGroup.interactable = false;
        _HUD_CanvasGroup.blocksRaycasts = false;
    }
}
