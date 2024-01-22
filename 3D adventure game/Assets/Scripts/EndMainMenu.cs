using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndMainMenu : MonoBehaviour
{
    IEnumerator LoadMenuScene()
    {
        Time.timeScale = 1;

        AsyncOperation MenuLoad = SceneManager.LoadSceneAsync("Menu");

        // Wait until the asynchronous scene fully loads
        while (!MenuLoad.isDone)
        {
            yield return null;
        }
    }

    public void ButtonHandlerMainMenu()
    {
        // Use a coroutine to load the Scene in the background
        StartCoroutine(LoadMenuScene());
    }
}
