using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PortalSceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Portal transition loaders
    IEnumerator LoadPortalScene1()
    {
        Time.timeScale = 1;
        // The Application loads the Scene in the background as the current Scene runs.

        AsyncOperation PortalSceneLoad = SceneManager.LoadSceneAsync("Portal Transitions1");

        // Wait until the asynchronous scene fully loads
        while (!PortalSceneLoad.isDone)
        {
            yield return null;
        }
    }

    IEnumerator LoadPortalScene2()
    {
        Time.timeScale = 1;
        // The Application loads the Scene in the background as the current Scene runs.

        AsyncOperation PortalSceneLoad = SceneManager.LoadSceneAsync("Portal Transitions2");

        // Wait until the asynchronous scene fully loads
        while (!PortalSceneLoad.isDone)
        {
            yield return null;
        }
    }

    IEnumerator LoadPortalScene3()
    {
        Time.timeScale = 1;
        // The Application loads the Scene in the background as the current Scene runs.

        AsyncOperation PortalSceneLoad = SceneManager.LoadSceneAsync("Portal Transitions3");

        // Wait until the asynchronous scene fully loads
        while (!PortalSceneLoad.isDone)
        {
            yield return null;
        }
    }

    IEnumerator LoadPortalScene4()
    {
        Time.timeScale = 1;
        // The Application loads the Scene in the background as the current Scene runs.

        AsyncOperation PortalSceneLoad = SceneManager.LoadSceneAsync("Portal Transitions4");

        // Wait until the asynchronous scene fully loads
        while (!PortalSceneLoad.isDone)
        {
            yield return null;
        }
    }

    //Portal transition accessors
    public void PortalScene1()
    {
        Cursor.lockState = CursorLockMode.None;

        // Use a coroutine to load the Scene in the background
        StartCoroutine(LoadPortalScene1());
    }

    public void PortalScene2()
    {
        Cursor.lockState = CursorLockMode.None;

        // Use a coroutine to load the Scene in the background
        StartCoroutine(LoadPortalScene2());
    }

    public void PortalScene3()
    {
        Cursor.lockState = CursorLockMode.None;

        // Use a coroutine to load the Scene in the background
        StartCoroutine(LoadPortalScene3());
    }

    public void PortalScene4()
    {
        Cursor.lockState = CursorLockMode.None;

        // Use a coroutine to load the Scene in the background
        StartCoroutine(LoadPortalScene4());
    }
}
