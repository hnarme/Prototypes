using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtonManager : MonoBehaviour
{
    public LevelLoader LevelLoader;
    public LockedLevelCheck lockedLevelCheck;

    public GameObject buttonPlay;
    public GameObject buttonCredits;
    public GameObject buttonLevels;
    public GameObject buttonEndless;
    public GameObject mainUI;
    public GameObject levelUI;

    //check if the level is locked. If the level is locked change the button colour.
    public GameObject[] levelButtons;


    // Start is called before the first frame update
    void Start()
    {
        buttonPlay.SetActive(true);
        mainUI.SetActive(true);
        levelUI.SetActive(false);
    }

    void Update()
    {
        levelButtons = GameObject.FindGameObjectsWithTag("LevelButtons");

        foreach (GameObject levelbutton in levelButtons)
        {

            switch (levelbutton.name)
            {
                case "ButtonLevel1":
                    {
                        if (!lockedLevelCheck.isLevel1Unlocked)
                        {
                            levelbutton.GetComponent<Image>().color = Color.grey;
                        }
                        else
                        {
                            levelbutton.GetComponent<Image>().color = Color.white;
                        }
                    }
                    break;
                case "ButtonLevel2":
                    {
                        if (!lockedLevelCheck.isLevel2Unlocked)
                        {
                            levelbutton.GetComponent<Image>().color = Color.grey;
                        }
                        else
                        {
                            levelbutton.GetComponent<Image>().color = Color.white;
                        }
                    }
                    break;
                case "ButtonLevel3":
                    {
                        if (!lockedLevelCheck.isLevel3Unlocked)
                        {
                            levelbutton.GetComponent<Image>().color = Color.grey;
                        }
                        else
                        {
                            levelbutton.GetComponent<Image>().color = Color.white;
                        }
                    }
                    break;
                case "ButtonLevel4":
                    {
                        if (!lockedLevelCheck.isLevel4Unlocked)
                        {
                            levelbutton.GetComponent<Image>().color = Color.grey;
                        }
                        else
                        {
                            levelbutton.GetComponent<Image>().color = Color.white;
                        }
                    }
                    break;
                case "ButtonLevel5":
                    {
                        if (!lockedLevelCheck.isLevel5Unlocked)
                        {
                            levelbutton.GetComponent<Image>().color = Color.grey;
                        }
                        else
                        {
                            levelbutton.GetComponent<Image>().color = Color.white;
                        }
                    }
                    break;
                case "ButtonLevel6":
                    {
                        if (!lockedLevelCheck.isLevel6Unlocked)
                        {
                            levelbutton.GetComponent<Image>().color = Color.grey;
                        }
                        else
                        {
                            levelbutton.GetComponent<Image>().color = Color.white;
                        }
                    }
                    break;
                case "ButtonLevel7":
                    {
                        if (!lockedLevelCheck.isLevel7Unlocked)
                        {
                            levelbutton.GetComponent<Image>().color = Color.grey;
                        }
                        else
                        {
                            levelbutton.GetComponent<Image>().color = Color.white;
                        }
                    }
                    break;
                case "ButtonLevel8":
                    {
                        if (!lockedLevelCheck.isLevel8Unlocked)
                        {
                            levelbutton.GetComponent<Image>().color = Color.grey;
                        }
                        else
                        {
                            levelbutton.GetComponent<Image>().color = Color.white;
                        }
                    }
                    break;
                case "ButtonLevel9":
                    {
                        if (!lockedLevelCheck.isLevel9Unlocked)
                        {
                            levelbutton.GetComponent<Image>().color = Color.grey;
                        }
                        else
                        {
                            levelbutton.GetComponent<Image>().color = Color.white;
                        }
                    }
                    break;
                case "ButtonLevel10":
                    {
                        if (!lockedLevelCheck.isLevel10Unlocked)
                        {
                            levelbutton.GetComponent<Image>().color = Color.grey;
                        }
                        else
                        {
                            levelbutton.GetComponent<Image>().color = Color.white;
                        }
                    }
                    break;
                case "ButtonLevel11":
                    {
                        if (!lockedLevelCheck.isLevel11Unlocked)
                        {
                            levelbutton.GetComponent<Image>().color = Color.grey;
                        }
                        else
                        {
                            levelbutton.GetComponent<Image>().color = Color.white;
                        }
                    }
                    break;
                case "ButtonLevel12":
                    {
                        if (!lockedLevelCheck.isLevel12Unlocked)
                        {
                            levelbutton.GetComponent<Image>().color = Color.grey;
                        }
                        else
                        {
                            levelbutton.GetComponent<Image>().color = Color.white;
                        }
                    }
                    break;
                case "ButtonLevel13":
                    {
                        if (!lockedLevelCheck.isLevel13Unlocked)
                        {
                            levelbutton.GetComponent<Image>().color = Color.grey;
                        }
                        else
                        {
                            levelbutton.GetComponent<Image>().color = Color.white;
                        }
                    }
                    break;
                case "ButtonLevel14":
                    {
                        if (!lockedLevelCheck.isLevel14Unlocked)
                        {
                            levelbutton.GetComponent<Image>().color = Color.grey;
                        }
                        else
                        {
                            levelbutton.GetComponent<Image>().color = Color.white;
                        }
                    }
                    break;
                case "ButtonLevel15":
                    {
                        if (!lockedLevelCheck.isLevel15Unlocked)
                        {
                            levelbutton.GetComponent<Image>().color = Color.grey;
                        }
                        else
                        {
                            levelbutton.GetComponent<Image>().color = Color.white;
                        }
                    }
                    break;
                case "ButtonLevel16":
                    {
                        if (!lockedLevelCheck.isLevel16Unlocked)
                        {
                            levelbutton.GetComponent<Image>().color = Color.grey;
                        }
                        else
                        {
                            levelbutton.GetComponent<Image>().color = Color.white;
                        }
                    }
                    break;
                case "ButtonLevel17":
                    {
                        if (!lockedLevelCheck.isLevel17Unlocked)
                        {
                            levelbutton.GetComponent<Image>().color = Color.grey;
                        }
                        else
                        {
                            levelbutton.GetComponent<Image>().color = Color.white;
                        }
                    }
                    break;
                case "ButtonLevel18":
                    {
                        if (!lockedLevelCheck.isLevel18Unlocked)
                        {
                            levelbutton.GetComponent<Image>().color = Color.grey;
                        }
                        else
                        {
                            levelbutton.GetComponent<Image>().color = Color.white;
                        }
                    }
                    break;
                case "ButtonLevel19":
                    {
                        if (!lockedLevelCheck.isLevel19Unlocked)
                        {
                            levelbutton.GetComponent<Image>().color = Color.grey;
                        }
                        else
                        {
                            levelbutton.GetComponent<Image>().color = Color.white;
                        }
                    }
                    break;
                case "ButtonLevel20":
                    {
                        if (!lockedLevelCheck.isLevel20Unlocked)
                        {
                            levelbutton.GetComponent<Image>().color = Color.grey;
                        }
                        else
                        {
                            levelbutton.GetComponent<Image>().color = Color.white;
                        }
                    }
                    break;
            }
        }
    }

        public void ButtonHandlerPlay()
    {
        buttonPlay.SetActive(false);
        buttonCredits.SetActive(false);
        buttonLevels.SetActive(true);
        buttonEndless.SetActive(true);
    }

    public void ButtonHandlerLevels()
    {
        mainUI.SetActive(false);
        levelUI.SetActive(true);
    }

    public void ButtonHandlerEndless()
    {
        StartCoroutine(LoadendlessgameScene());
    }

    IEnumerator LoadendlessgameScene()
    {
        Time.timeScale = 1.0f;

        AsyncOperation gameLoad = SceneManager.LoadSceneAsync("GameEndless");

        // Wait until the asynchronous scene fully loads
        while (!gameLoad.isDone)
        {
            yield return null;
        }
    }

    public void ButtonHandlerBack()
    {
        StartCoroutine(LoadmainmenuScene());
    }

    IEnumerator LoadmainmenuScene()
    {
        Time.timeScale = 1.0f;

        AsyncOperation mainMenuLoad = SceneManager.LoadSceneAsync("Main Menu");

        // Wait until the asynchronous scene fully loads
        while (!mainMenuLoad.isDone)
        {
            yield return null;
        }
    }

    public void ButtonHandlerLevel1()
    {
        if (lockedLevelCheck.isLevel1Unlocked)
        {
            StartCoroutine(LevelLoader.Loadlevel1Scene());
        }
        else
        {
            
        }
    }

    public void ButtonHandlerLevel2()
    {
        if (lockedLevelCheck.isLevel2Unlocked)
        {
            StartCoroutine(LevelLoader.Loadlevel1Scene());
        }
        else
        {

        }
    }

    public void ButtonHandlerLevel3()
    {
        if (lockedLevelCheck.isLevel3Unlocked)
        {
            StartCoroutine(LevelLoader.Loadlevel1Scene());
        }
        else
        {

        }
    }

    public void ButtonHandlerLevel4()
    {
        if (lockedLevelCheck.isLevel4Unlocked)
        {
            StartCoroutine(LevelLoader.Loadlevel1Scene());
        }
        else
        {

        }
    }

    public void ButtonHandlerLevel5()
    {
        if (lockedLevelCheck.isLevel5Unlocked)
        {
            StartCoroutine(LevelLoader.Loadlevel1Scene());
        }
        else
        {

        }
    }

    public void ButtonHandlerLevel6()
    {
        if (lockedLevelCheck.isLevel6Unlocked)
        {
            StartCoroutine(LevelLoader.Loadlevel1Scene());
        }
        else
        {

        }
    }

    public void ButtonHandlerLevel7()
    {
        if (lockedLevelCheck.isLevel7Unlocked)
        {
            StartCoroutine(LevelLoader.Loadlevel1Scene());
        }
        else
        {

        }
    }

    public void ButtonHandlerLevel8()
    {
        if (lockedLevelCheck.isLevel8Unlocked)
        {
            StartCoroutine(LevelLoader.Loadlevel1Scene());
        }
        else
        {

        }
    }

    public void ButtonHandlerLevel9()
    {
        if (lockedLevelCheck.isLevel9Unlocked)
        {
            StartCoroutine(LevelLoader.Loadlevel1Scene());
        }
        else
        {

        }
    }

    public void ButtonHandlerLevel10()
    {
        if (lockedLevelCheck.isLevel10Unlocked)
        {
            StartCoroutine(LevelLoader.Loadlevel1Scene());
        }
        else
        {

        }
    }

    public void ButtonHandlerLevel11()
    {
        if (lockedLevelCheck.isLevel11Unlocked)
        {
            StartCoroutine(LevelLoader.Loadlevel1Scene());
        }
        else
        {

        }
    }

    public void ButtonHandlerLevel12()
    {
        if (lockedLevelCheck.isLevel12Unlocked)
        {
            StartCoroutine(LevelLoader.Loadlevel1Scene());
        }
        else
        {

        }
    }

    public void ButtonHandlerLevel13()
    {
        if (lockedLevelCheck.isLevel13Unlocked)
        {
            StartCoroutine(LevelLoader.Loadlevel1Scene());
        }
        else
        {

        }
    }

    public void ButtonHandlerLevel14()
    {
        if (lockedLevelCheck.isLevel14Unlocked)
        {
            StartCoroutine(LevelLoader.Loadlevel1Scene());
        }
        else
        {

        }
    }

    public void ButtonHandlerLevel15()
    {
        if (lockedLevelCheck.isLevel15Unlocked)
        {
            StartCoroutine(LevelLoader.Loadlevel1Scene());
        }
        else
        {

        }
    }

    public void ButtonHandlerLevel16()
    {
        if (lockedLevelCheck.isLevel16Unlocked)
        {
            StartCoroutine(LevelLoader.Loadlevel1Scene());
        }
        else
        {

        }
    }

    public void ButtonHandlerLevel17()
    {
        if (lockedLevelCheck.isLevel17Unlocked)
        {
            StartCoroutine(LevelLoader.Loadlevel1Scene());
        }
        else
        {

        }
    }

    public void ButtonHandlerLevel18()
    {
        if (lockedLevelCheck.isLevel18Unlocked)
        {
            StartCoroutine(LevelLoader.Loadlevel1Scene());
        }
        else
        {

        }
    }

    public void ButtonHandlerLevel19()
    {
        if (lockedLevelCheck.isLevel19Unlocked)
        {
            StartCoroutine(LevelLoader.Loadlevel1Scene());
        }
        else
        {

        }
    }

    public void ButtonHandlerLevel20()
    {
        if (lockedLevelCheck.isLevel20Unlocked)
        {
            StartCoroutine(LevelLoader.Loadlevel1Scene());
        }
        else
        {

        }
    }

}
