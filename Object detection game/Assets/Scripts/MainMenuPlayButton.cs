using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuPlayButton : MonoBehaviour
{
    public Timer timer;

    public string buttonName = "PlayButton";

    public bool enterdButton = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Cursor")
        {
            enterdButton = true;
            timer.EnableTimer();
            StartCoroutine(timer.StartCountDown());
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        enterdButton = false;
        timer.DisableTimer();
        StopAllCoroutines();
        timer.countDownTimer = 3;
    }
}
