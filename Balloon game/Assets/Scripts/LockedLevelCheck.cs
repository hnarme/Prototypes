using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This script checks if the level has been completed or not


public class LockedLevelCheck : MonoBehaviour
{
    public int level;

    public bool isBalloonGoalAchieved;
    public bool isLevel1Unlocked;
    public bool isLevel2Unlocked;
    public bool isLevel3Unlocked;
    public bool isLevel4Unlocked;
    public bool isLevel5Unlocked;
    public bool isLevel6Unlocked;
    public bool isLevel7Unlocked;
    public bool isLevel8Unlocked;
    public bool isLevel9Unlocked;
    public bool isLevel10Unlocked;
    public bool isLevel11Unlocked;
    public bool isLevel12Unlocked;
    public bool isLevel13Unlocked;
    public bool isLevel14Unlocked;
    public bool isLevel15Unlocked;
    public bool isLevel16Unlocked;
    public bool isLevel17Unlocked;
    public bool isLevel18Unlocked;
    public bool isLevel19Unlocked;
    public bool isLevel20Unlocked;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Levelchecker();
    }

    public void Levelchecker()
    {
        Scene scene = SceneManager.GetActiveScene();

        switch (scene.name)
        {
            case "GameLevel 1":
                {
                    level = 1;
                    isLevel1Unlocked = true;
                }
                break;
            case "GameLevel 2":
                {
                    level = 2;
                    if (isBalloonGoalAchieved)
                    {
                        isLevel2Unlocked = true;
                    }
                    else
                    {
                        isLevel2Unlocked = false;
                    }
                }
                break;
            case "GameLevel 3":
                {
                    level = 3;
                    if (isBalloonGoalAchieved)
                    {
                        isLevel3Unlocked = true;
                    }
                    else
                    {
                        isLevel3Unlocked = false;
                    }
                }
                break;
            case "GameLevel 4":
                {
                    level = 4;
                    if (isBalloonGoalAchieved)
                    {
                        isLevel4Unlocked = true;
                    }
                    else
                    {
                        isLevel4Unlocked = false;
                    }
                }
                break;
            case "GameLevel 5":
                {
                    level = 5;
                    if (isBalloonGoalAchieved)
                    {
                        isLevel5Unlocked = true;
                    }
                    else
                    {
                        isLevel5Unlocked = false;
                    }
                }
                break;
            case "GameLevel 6":
                {
                    level = 6;
                    if (isBalloonGoalAchieved)
                    {
                        isLevel6Unlocked = true;
                    }
                    else
                    {
                        isLevel6Unlocked = false;
                    }
                }
                break;
            case "GameLevel 7":
                {
                    level = 7;
                    if (isBalloonGoalAchieved)
                    {
                        isLevel7Unlocked = true;
                    }
                    else
                    {
                        isLevel7Unlocked = false;
                    }
                }
                break;
            case "GameLevel 8":
                {
                    level = 8;
                    if (isBalloonGoalAchieved)
                    {
                        isLevel8Unlocked = true;
                    }
                    else
                    {
                        isLevel8Unlocked = false;
                    }
                }
                break;
            case "GameLevel 9":
                {
                    level = 9;
                    if (isBalloonGoalAchieved)
                    {
                        isLevel9Unlocked = true;
                    }
                    else
                    {
                        isLevel9Unlocked = false;
                    }
                }
                break;
            case "GameLevel 10":
                {
                    level = 10;
                    if (isBalloonGoalAchieved)
                    {
                        isLevel10Unlocked = true;
                    }
                    else
                    {
                        isLevel10Unlocked = false;
                    }
                }
                break;
            case "GameLevel 11":
                {
                    level = 11;
                    if (isBalloonGoalAchieved)
                    {
                        isLevel11Unlocked = true;
                    }
                    else
                    {
                        isLevel11Unlocked = false;
                    }
                }
                break;
            case "GameLevel 12":
                {
                    level = 12;
                    if (isBalloonGoalAchieved)
                    {
                        isLevel12Unlocked = true;
                    }
                    else
                    {
                        isLevel12Unlocked = false;
                    }
                }
                break;
            case "GameLevel 13":
                {
                    level = 13;
                    if (isBalloonGoalAchieved)
                    {
                        isLevel13Unlocked = true;
                    }
                    else
                    {
                        isLevel13Unlocked = false;
                    }
                }
                break;
            case "GameLevel 14":
                {
                    level = 14;
                    if (isBalloonGoalAchieved)
                    {
                        isLevel14Unlocked = true;
                    }
                    else
                    {
                        isLevel14Unlocked = false;
                    }
                }
                break;
            case "GameLevel 15":
                {
                    level = 15;
                    if (isBalloonGoalAchieved)
                    {
                        isLevel15Unlocked = true;
                    }
                    else
                    {
                        isLevel15Unlocked = false;
                    }
                }
                break;
            case "GameLevel 16":
                {
                    level = 16;
                    if (isBalloonGoalAchieved)
                    {
                        isLevel16Unlocked = true;
                    }
                    else
                    {
                        isLevel16Unlocked = false;
                    }
                }
                break;
            case "GameLevel 17":
                {
                    level = 17;
                    if (isBalloonGoalAchieved)
                    {
                        isLevel17Unlocked = true;
                    }
                    else
                    {
                        isLevel17Unlocked = false;
                    }
                }
                break;
            case "GameLevel 18":
                {
                    level = 18;
                    if (isBalloonGoalAchieved)
                    {
                        isLevel18Unlocked = true;
                    }
                    else
                    {
                        isLevel18Unlocked = false;
                    }
                }
                break;
            case "GameLevel 19":
                {
                    level = 19;
                    if (isBalloonGoalAchieved)
                    {
                        isLevel19Unlocked = true;
                    }
                    else
                    {
                        isLevel19Unlocked = false;
                    }
                }
                break;
            case "GameLevel 20":
                {
                    level = 20;
                    if (isBalloonGoalAchieved)
                    {
                        isLevel20Unlocked = true;
                    }
                    else
                    {
                        isLevel20Unlocked = false;
                    }
                }
                break;
        }
    }
}
