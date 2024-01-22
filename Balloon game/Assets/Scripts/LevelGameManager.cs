using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelGameManager : MonoBehaviour
{
    public LockedLevelCheck lockedLevelCheck;

    //public LevelBalloonMovement levelBalloonMovement;
    public SpikeChecker spikeChecker;

    public GameObject[] prefab;
    public GameObject gameOverScreen;

    public int level;
    public int currentBalloonsPopped;
    public int randomNum;

    public bool isBalloonGoalAchieved;

    public TMP_Text balloonText;

    public GameObject buttonNext;
    public GameObject buttonRetry;

    void Start()
    {
        gameOverScreen.SetActive(false);
    }

    void Update()
    {
        level = lockedLevelCheck.level;

        Time.timeScale = 1;
        prefab = GameObject.FindGameObjectsWithTag("balloon");

        GameOverScreenOverlay();
        lockedLevelCheck.Levelchecker();

        if (spikeChecker.GetComponent<SpikeChecker>().spikeTouched == true)
        {
            Clearallballoons();
            balloonText.text = "You Lost";
            isBalloonGoalAchieved = false;
            lockedLevelCheck.isBalloonGoalAchieved = false;
            gameOverScreen.SetActive(true);
            buttonNext.SetActive(false);
            buttonRetry.SetActive(true);
            Time.timeScale = 0;
        }

        foreach (GameObject balloonSprite in prefab)
        {
            //****activates the child red balloon gameobject****
            balloonSprite.transform.Find("red balloon").gameObject.SetActive(true);
            //****activates the child red balloon gameobject****

            CircleCollider2D coll = balloonSprite.GetComponent<CircleCollider2D>();

            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                if (coll.OverlapPoint(mousePos))
                {
                    currentBalloonsPopped++;
                    balloonSprite.SetActive(false);
                }
            }

            if (spikeChecker.GetComponent<SpikeChecker>().spikeTouched == true)
            {
                balloonSprite.SetActive(false);
            }
        }
    }

    void GameOverScreenOverlay()
    {
        if (currentBalloonsPopped == 8)
        {
            Clearallballoons();
            balloonText.text = "You Won";
            isBalloonGoalAchieved = true;
            lockedLevelCheck.isBalloonGoalAchieved = true;
            gameOverScreen.SetActive(true);
            buttonNext.SetActive(true);
            buttonRetry.SetActive(false);
            Time.timeScale = 0;
        }
    }



    void Clearallballoons()
    {
        for (int i = 0; i < prefab.Length; i++)
        {
            prefab[i].SetActive(false);
        }
    }
}