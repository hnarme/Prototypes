using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public bool isGamePaused = false;
    public GameObject PauseMenuUI;
    public GameObject Weapon;
    public GameObject PauseButton;

    public PauseTimer pauseTime;

    // Start is called before the first frame update
    void Start()
    {
        Weapon = GameObject.Find("Weapon");
        PauseButton = GameObject.Find("PauseButton");
    }

    // Update is called once per frame
    void Update()
    {
        if (pauseTime.countDownTimer == 0)
        {
            isGamePaused = true;
            Pause();
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Weapon.SetActive(true);
        PauseButton.SetActive(true);
        Time.timeScale = 1;
        isGamePaused = false;
    }

    public void Pause()
    {
        pauseTime.DisableTimer();
        PauseMenuUI.SetActive(true);
        Weapon.SetActive(false);
        PauseButton.SetActive(false);
        Time.timeScale = 0;
        isGamePaused = true;
    }
}
