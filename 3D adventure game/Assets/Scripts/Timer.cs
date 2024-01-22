using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public LevelLoader levelLoader;

    public int countDownTimer = 8;

    Scene scene;


    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        scene = SceneManager.GetActiveScene();

        StartCoroutine(StartCountDown());

        if (countDownTimer <= 0)
        {
            if(scene.name == "Portal Transitions1")
            {
                levelLoader.Level1();
            }
            else if (scene.name == "Portal Transitions2")
            {
                levelLoader.Level2();
            }
            else if (scene.name == "Portal Transitions3")
            {
                levelLoader.Level3();
            }
            else if (scene.name == "Portal Transitions4")
            {
                levelLoader.Level4();
            }
        }
    }

    public IEnumerator StartCountDown()
    {
        while (countDownTimer > 0)
        {
            yield return new WaitForSeconds(2f);

            countDownTimer--;
        }
    }
}
