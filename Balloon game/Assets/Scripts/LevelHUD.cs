using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class LevelHUD : MonoBehaviour
{
    public LevelGameManager levelGameManager;

    public int balloonsCount;
    public int counterSum;
    public int levelnum;

    public TMP_Text countText;
    public TMP_Text levelNumberText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        balloonsCount = levelGameManager.GetComponent<LevelGameManager>().currentBalloonsPopped;

        levelnum = levelGameManager.GetComponent<LevelGameManager>().level;

        counterSum = 8 - balloonsCount;

        countText.text = "Balloons: " + counterSum.ToString();

        levelNumberText.text = "Level: " + levelnum.ToString();

    }
}
