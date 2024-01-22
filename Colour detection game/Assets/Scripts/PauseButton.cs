using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public PauseTimer pauseTimer;

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
        if (collider.gameObject.tag == "Weapon")
        {
            enterdButton = true;
            pauseTimer.EnableTimer();
            StartCoroutine(pauseTimer.StartCountDown());
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        enterdButton = false;
        pauseTimer.DisableTimer();
        StopAllCoroutines();
        pauseTimer.countDownTimer = 3;
    }
}
