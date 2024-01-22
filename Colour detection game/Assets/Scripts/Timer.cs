using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameManager gameManager;
    public MenuManager menuManager;

    public GameObject timerDisplay;
    public TMP_Text timeText;
    public int countDownTimer;

    public string buttonName;

    public MainMenuPlayButton playButton;
    public MainMenuExitButton exitButton;
    public ResumeButton resumeButton;
    public MainMenuButtonPause mainMenuButton;
    public QuitButton quitButton;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        Scene scene = SceneManager.GetActiveScene();


        if (scene.name == "Main Menu")
        {
            if (playButton.enterdButton)
            {
                buttonName = "PlayButton";
            }

            if (exitButton.enterdButton)
            {
                buttonName = "ExitButton";
            }
        }


        if (resumeButton.enterdButton)
        {
            buttonName = "ResumeButton";
        }

        if (mainMenuButton.enterdButton)
        {
            buttonName = "MainMenuButton";
        }

        if(quitButton.enterdButton)
        {
            buttonName = "ExitButton";
        }

    }

    public IEnumerator StartCountDown()
    {
        while (countDownTimer > 0)
        {
            timeText.text = countDownTimer.ToString();

            yield return new WaitForSeconds(1f);

            countDownTimer--;

        }

        if (countDownTimer == 0)
        {
            if (buttonName == "PlayButton")
            {
                Debug.Log("Start Game");
                gameManager.CutsceneIntro();
            }

            if (buttonName == "ExitButton")
            {
                Debug.Log("Exit Game");
                Application.Quit();
            }

            if(buttonName == "ResumeButton")
            {
                Debug.Log("Resume Game");
                menuManager.Resume();
            }

            if(buttonName == "MainMenuButton")
            {
                Debug.Log("To the MainMenu");
                gameManager.MainMenu();
            }
        }
    }

    public void EnableTimer()
    {
        timerDisplay.SetActive(true);
    }

    public void DisableTimer()
    {
        timerDisplay.SetActive(false);
    }
}
