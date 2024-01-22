using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    private int flycount;

    public Text flycountText;
    public GameObject Win_Menu;

    void Start()
    {
        flycount = GameObject.FindGameObjectsWithTag("Fly").Length;
        Win_Menu.SetActive(false);
        ShowLevelCompleteMenu();
    }

    void FixedUpdate()
    {
        
    }

    public void subtractScore()
    {
        flycount = flycount - 1;
        ShowLevelCompleteMenu();
    }

    void ShowLevelCompleteMenu()
    {
        flycountText.text = "Flies left: " + flycount.ToString();
        if (flycount == 0)
        {
            Win_Menu.SetActive(true);
        }
    }
}
