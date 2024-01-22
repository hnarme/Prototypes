using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthManager : MonoBehaviour
{
    public int healthCount;

    public Text HealthText;
    public GameObject Win_Menu;

    void Start()
    {
        healthCount = 3;
        ShowLevelCompleteMenu();
    }

    public int Gethealth()
    {
       return healthCount;
    }

    public void SubtractHealth()
    {
        healthCount -= 1;
        ShowLevelCompleteMenu();
    }

    void ShowLevelCompleteMenu()
    {
        HealthText.text = "Health: " + healthCount.ToString();
        if (healthCount == 0)
        {
            Win_Menu.SetActive(true);
        }
    }
}
