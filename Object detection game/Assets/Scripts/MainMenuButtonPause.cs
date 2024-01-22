using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButtonPause : MonoBehaviour
{
    public Timer timer;

    public string buttonName = "MainMenuButton";

    public bool enterdButton = false;

    public Animator animator;
    public bool isButtonActive = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isButtonActive", isButtonActive);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Cursor")
        {
            enterdButton = true;
            isButtonActive = true;
            timer.EnableTimer();
            StartCoroutine(timer.StartCountDown());
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        enterdButton = false;
        isButtonActive = false;
        timer.DisableTimer();
        StopAllCoroutines();
        timer.countDownTimer = 3;
    }
}
