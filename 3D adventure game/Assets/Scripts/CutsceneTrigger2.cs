using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneTrigger2 : MonoBehaviour
{
    public CutsceneController controller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            controller.TutorialCutscene2();
            gameObject.SetActive(false);
        }
    }
}
