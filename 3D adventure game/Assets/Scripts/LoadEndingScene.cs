using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadEndingScene : MonoBehaviour
{
    IEnumerator LoadEndScene()
    {
        Time.timeScale = 1;
        // The Application loads the Scene in the background as the current Scene runs.

        AsyncOperation PortalSceneLoad = SceneManager.LoadSceneAsync("Ending");

        // Wait until the asynchronous scene fully loads
        while (!PortalSceneLoad.isDone)
        {
            yield return null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            StartCoroutine(LoadEndScene());
        }
    }
}
