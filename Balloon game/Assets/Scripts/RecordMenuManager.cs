using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RecordMenuManager : MonoBehaviour
{
    public GameObject recordDisplay;

    public balloonsIndex balloonsIndex;

    public int balloonsCount;

    public TMP_Text recordText;


    private void Start()
    {
        recordDisplay = null;
    }

    void Update()
    {
        recordDisplay = GameObject.Find("Main Camera/MainUI/RecordText");

        balloonsCount = balloonsIndex.GetComponent<balloonsIndex>().balloonsRecord;
        
        recordText.text = "Current record: " + balloonsCount.ToString();

        if (balloonsCount == 0)
        {
            recordDisplay.SetActive(false);
        }
        else
        {
            recordDisplay.SetActive(true);
        }
    }
}
