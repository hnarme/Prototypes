using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndlessGameManager : MonoBehaviour
{
    public balloonsIndex BalloonsIndex;
    public balloonMovementV2 balloonMovement;
    public SpikeChecker spikeChecker;

    public GameObject[] prefab;
    public GameObject gameOverScreen;

    public int level;
    public int currentBalloonsPopped;
    public int randomNum;

    public TMP_Text balloonText;

    void Start()
    {
        
    }

    void Update()
    {
        Time.timeScale = 1;
        prefab = GameObject.FindGameObjectsWithTag("balloon");

        GameOverScreenOverlay();

        BalloonsIndex.GetComponent<balloonsIndex>().balloonsStored = currentBalloonsPopped;

        if (spikeChecker.GetComponent<SpikeChecker>().spikeTouched == true)
        {
            BalloonsIndex.GetComponent<balloonsIndex>().Updaterecordballoon();
            gameOverScreen.SetActive(true);
            Time.timeScale = 0;
            BalloonsIndex.GetComponent<balloonsIndex>().Resetballooncount();
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
                    level++;
                    currentBalloonsPopped++;
                    BalloonsIndex.GetComponent<balloonsIndex>().Incrementballoon();
                    balloonSprite.SetActive(false);
                }
            }

            //if (balloonMovement.colourNum == 0)
            //{
            //    balloonSprite.transform.Find("red balloon").gameObject.SetActive(true);
            //}
            //else if (balloonMovement.colourNum == 1)
            //{
            //    balloonSprite.transform.Find("yellow balloon").gameObject.SetActive(true);
            //}
            //else if (balloonMovement.colourNum == 2)
            //{
            //    balloonSprite.transform.Find("orange balloon").gameObject.SetActive(true);
            //}
            //else if (balloonMovement.colourNum == 3)
            //{
            //    balloonSprite.transform.Find("green balloon").gameObject.SetActive(true);
            //}
            //else if (balloonMovement.colourNum == 4)
            //{
            //    balloonSprite.transform.Find("blue balloon").gameObject.SetActive(true);
            //}
            //else if (balloonMovement.colourNum == 5)
            //{
            //    balloonSprite.transform.Find("black balloon").gameObject.SetActive(true);
            //}

            //if (currentBalloonsPopped <= 4)
            //{
            //    balloonSprite.transform.Find("red balloon").gameObject.SetActive(true);
            //}

            //if (currentBalloonsPopped >= 5 && currentBalloonsPopped <= 9)
            //{
            //    balloonSprite.transform.Find("yellow balloon").gameObject.SetActive(true);
            //}

            //if (currentBalloonsPopped >= 10 && currentBalloonsPopped <= 14)
            //{
            //    balloonSprite.transform.Find("orange balloon").gameObject.SetActive(true);
            //}

            //if (currentBalloonsPopped >= 15 && currentBalloonsPopped <= 19)
            //{
            //    balloonSprite.transform.Find("green balloon").gameObject.SetActive(true);
            //}

            //if (currentBalloonsPopped >= 20 && currentBalloonsPopped <= 24)
            //{
            //    balloonSprite.transform.Find("blue balloon").gameObject.SetActive(true);
            //}

            //if (currentBalloonsPopped >= 25)
            //{
            //    balloonSprite.transform.Find("black balloon").gameObject.SetActive(true);
            //}


            if (spikeChecker.GetComponent<SpikeChecker>().spikeTouched == true)
            {
                balloonSprite.SetActive(false);
            }
        }
    }

    void GameOverScreenOverlay()
    {
        if (currentBalloonsPopped <= 0)
        {
            balloonText.text = "You popped " + currentBalloonsPopped.ToString() + " balloons, how embarrassing";
        }
        else if (currentBalloonsPopped == 1)
        {
            balloonText.text = "You only popped " + currentBalloonsPopped.ToString() + " balloon?";
        }
        else if (currentBalloonsPopped >= 2 && currentBalloonsPopped <= 10)
        {
            balloonText.text = "You only popped " + currentBalloonsPopped.ToString() + " balloons";
        }
        else
        {
            balloonText.text = "You popped " + currentBalloonsPopped.ToString() + " balloons!!!";
        }
    }
}
