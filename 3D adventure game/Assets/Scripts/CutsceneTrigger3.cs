using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneTrigger3 : MonoBehaviour
{
    public CutsceneController controller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            controller.TutorialCutscene3();
            gameObject.SetActive(false);
        }
    }
}
