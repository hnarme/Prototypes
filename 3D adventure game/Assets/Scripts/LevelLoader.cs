using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Level loaders
    IEnumerator LoadTutorialLevelScene()
    {
        Time.timeScale = 1;

        AsyncOperation TutorialLoad = SceneManager.LoadSceneAsync("Tutorial - Town");

        // Wait until the asynchronous scene fully loads
        while (!TutorialLoad.isDone)
        {
            yield return null;
        }
    }

    IEnumerator LoadLevel1Scene()
    {
        Time.timeScale = 1;

        AsyncOperation Level1Load = SceneManager.LoadSceneAsync("Level 1 - Circle World");

        // Wait until the asynchronous scene fully loads
        while (!Level1Load.isDone)
        {
            yield return null;
        }
    }

    IEnumerator LoadLevel2Scene()
    {
        Time.timeScale = 1;

        AsyncOperation Level2Load = SceneManager.LoadSceneAsync("Level 2 - Thief's Trail");

        // Wait until the asynchronous scene fully loads
        while (!Level2Load.isDone)
        {
            yield return null;
        }

    }

    IEnumerator LoadLevel3Scene()
    {
        Time.timeScale = 1;

        AsyncOperation Level3Load = SceneManager.LoadSceneAsync("Level 3 - Climb");

        // Wait until the asynchronous scene fully loads
        while (!Level3Load.isDone)
        {
            yield return null;
        }
    }

    IEnumerator LoadLevel4Scene()
    {
        Time.timeScale = 1;
        // The Application loads the Scene in the background as the current Scene runs.

        AsyncOperation Level4Load = SceneManager.LoadSceneAsync("Level 4 - Castle");

        // Wait until the asynchronous scene fully loads
        while (!Level4Load.isDone)
        {
            yield return null;
        }
    }

    //level accessors
    public void Tutorial()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        // Use a coroutine to load the Scene in the background
        StartCoroutine(LoadLevel1Scene());

    }

    public void Level1()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        // Use a coroutine to load the Scene in the background
        StartCoroutine(LoadLevel1Scene());

    }

    public void Level2()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        // Use a coroutine to load the Scene in the background
        StartCoroutine(LoadLevel2Scene());

    }

    public void Level3()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        // Use a coroutine to load the Scene in the background
        StartCoroutine(LoadLevel3Scene());

    }

    public void Level4()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        // Use a coroutine to load the Scene in the background
        StartCoroutine(LoadLevel4Scene());

    }
}
