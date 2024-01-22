using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneTrigger1 : MonoBehaviour
{
    public GameObject logText;
    public CutsceneController controller;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            controller.TutorialCutscene1();
            logText.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}