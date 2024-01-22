using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GameButtonManager : MonoBehaviour
{
    public LevelLoader Levelloader;

    void Update()
    {
    
    }

    public void ButtonHandlerExit()
    {
        StartCoroutine(LoadmainmenuScene());
    }

    public void resetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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

    public void ButtonHandlerNextLevel()
    {
        Scene scene = SceneManager.GetActiveScene();

        switch (scene.name)
        {
            case "GameLevel 1":
                {
                    StartCoroutine(Levelloader.Loadlevel2Scene());
                }
                break;
            case "GameLevel 2":
                {
                    StartCoroutine(Levelloader.Loadlevel3Scene());
                }
                break;
            case "GameLevel 3":
                {
                    StartCoroutine(Levelloader.Loadlevel4Scene());
                }
                break;
            case "GameLevel 4":
                {
                    StartCoroutine(Levelloader.Loadlevel5Scene());
                }
                break;
            case "GameLevel 5":
                {
                    StartCoroutine(Levelloader.Loadlevel6Scene());
                }
                break;
            case "GameLevel 6":
                {
                    StartCoroutine(Levelloader.Loadlevel7Scene());
                }
                break;
            case "GameLevel 7":
                {
                    StartCoroutine(Levelloader.Loadlevel8Scene());
                }
                break;
            case "GameLevel 8":
                {
                    StartCoroutine(Levelloader.Loadlevel9Scene());
                }
                break;
            case "GameLevel 9":
                {
                    StartCoroutine(Levelloader.Loadlevel10Scene());
                }
                break;
            case "GameLevel 10":
                {
                    StartCoroutine(Levelloader.Loadlevel11Scene());
                }
                break;
            case "GameLevel 11":
                {
                    StartCoroutine(Levelloader.Loadlevel12Scene());
                }
                break;
            case "GameLevel 12":
                {
                    StartCoroutine(Levelloader.Loadlevel13Scene());
                }
                break;
            case "GameLevel 13":
                {
                    StartCoroutine(Levelloader.Loadlevel14Scene());
                }
                break;
            case "GameLevel 14":
                {
                    StartCoroutine(Levelloader.Loadlevel15Scene());
                }
                break;
            case "GameLevel 15":
                {
                    StartCoroutine(Levelloader.Loadlevel16Scene());
                }
                break;
            case "GameLevel 16":
                {
                    StartCoroutine(Levelloader.Loadlevel17Scene());
                }
                break;
            case "GameLevel 17":
                {
                    StartCoroutine(Levelloader.Loadlevel18Scene());
                }
                break;
            case "GameLevel 18":
                {
                    StartCoroutine(Levelloader.Loadlevel19Scene());
                }
                break;
            case "GameLevel 19":
                {
                    StartCoroutine(Levelloader.Loadlevel20Scene());
                }
                break;
            case "GameLevel 20":
                {
                    //Change to credits scene
                    StartCoroutine(Levelloader.Loadlevel1Scene());
                }
                break;
        }
    }
}
