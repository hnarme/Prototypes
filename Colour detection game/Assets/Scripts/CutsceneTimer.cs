using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneTimer : MonoBehaviour
{
    public GameManager gameManager;

    public int countDownTimer = 8;

    Scene scene;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = GetComponent<GameManager>();
    }

    private void Update()
    {
        scene = SceneManager.GetActiveScene();

        StartCoroutine(StartCountDown());

        if (countDownTimer == 0)
        {
            if (scene.name == "Cutscene - Intro")
            {
                gameManager.Level1();
            }
            else if (scene.name == "Cutscene - Natives")
            {
                gameManager.Level2();
            }
            else if (scene.name == "Cutscene - Collected Wood")
            {
                gameManager.Level3();
            }
            else if (scene.name == "Cutscene - Ending(Stay)")
            {
                gameManager.MainMenu();
            }
            else if (scene.name == "Cutscene - Ending(Leave)")
            {
                gameManager.MainMenu();
            }
        }

        if(Input.anyKey)
        {
            countDownTimer = 0;
        }
    }

    public IEnumerator StartCountDown()
    {
        while (countDownTimer > 0)
        {
            yield return new WaitForSeconds(20f);

            countDownTimer--;
        }
    }
}
