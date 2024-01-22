using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadMainMenuScene()
    {
        Time.timeScale = 1;
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation Level1Load = SceneManager.LoadSceneAsync("Main Menu");

        // Wait until the asynchronous scene fully loads
        while (!Level1Load.isDone)
        {
            yield return null;
        }
    }

    IEnumerator LoadCutscene1()
    {
        Time.timeScale = 1;
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation Level1Load = SceneManager.LoadSceneAsync("Cutscene - Intro");

        // Wait until the asynchronous scene fully loads
        while (!Level1Load.isDone)
        {
            yield return null;
        }
    }

    IEnumerator LoadLevel1Scene()
    {
        Time.timeScale = 1;
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation Level1Load = SceneManager.LoadSceneAsync("Level 1 - Crash");

        // Wait until the asynchronous scene fully loads
        while (!Level1Load.isDone)
        {
            yield return null;
        }
    }

    IEnumerator LoadCutscene2()
    {
        Time.timeScale = 1;
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation Level1Load = SceneManager.LoadSceneAsync("Cutscene - Natives");

        // Wait until the asynchronous scene fully loads
        while (!Level1Load.isDone)
        {
            yield return null;
        }
    }


    IEnumerator LoadLevel2Scene()
    {
        Time.timeScale = 1;
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation Level2Load = SceneManager.LoadSceneAsync("Level 2 - Natives");

        // Wait until the asynchronous scene fully loads
        while (!Level2Load.isDone)
        {
            yield return null;
        }

    }

    IEnumerator LoadCutscene3()
    {
        Time.timeScale = 1;
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation Level1Load = SceneManager.LoadSceneAsync("Cutscene - Collected Wood");

        // Wait until the asynchronous scene fully loads
        while (!Level1Load.isDone)
        {
            yield return null;
        }
    }
    IEnumerator LoadLevel3Scene()
    {
        Time.timeScale = 1;
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation Level3Load = SceneManager.LoadSceneAsync("Level 3 - Last Choice");

        // Wait until the asynchronous scene fully loads
        while (!Level3Load.isDone)
        {
            yield return null;
        }
    }

    IEnumerator LoadCutsceneStay()
    {
        Time.timeScale = 1;
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation Level1Load = SceneManager.LoadSceneAsync("Cutscene - Ending(Stay)");

        // Wait until the asynchronous scene fully loads
        while (!Level1Load.isDone)
        {
            yield return null;
        }
    }

    IEnumerator LoadCutsceneLeave()
    {
        Time.timeScale = 1;
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation Level1Load = SceneManager.LoadSceneAsync("Cutscene - Ending(Leave)");

        // Wait until the asynchronous scene fully loads
        while (!Level1Load.isDone)
        {
            yield return null;
        }
    }

    public void MainMenu()
    {
        // Use a coroutine to load the Scene in the background
        StartCoroutine(LoadMainMenuScene());
    }

    public void CutsceneIntro()
    {
        StartCoroutine(LoadCutscene1());
    }

    public void Level1()
    {
        // Use a coroutine to load the Scene in the background
        StartCoroutine(LoadLevel1Scene());
    }

    public void CutsceneNatives()
    {
        StartCoroutine(LoadCutscene2());
    }

    public void Level2()
    {
        // Use a coroutine to load the Scene in the background
        StartCoroutine(LoadLevel2Scene());
    }

    public void CutsceneLogCollecting()
    {
        StartCoroutine(LoadCutscene3());
    }

    public void Level3()
    {
        // Use a coroutine to load the Scene in the background
        StartCoroutine(LoadLevel3Scene());
    }

    public void CutsceneLeave()
    {
        StartCoroutine(LoadCutsceneLeave());
    }

    public void CutsceneStay()
    {
        StartCoroutine(LoadCutsceneStay());
    }

}
