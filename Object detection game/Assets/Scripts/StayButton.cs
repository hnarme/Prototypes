using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StayButton : MonoBehaviour
{
    public GameManager gameManager;
    public Animator animator;

    public bool isButtonActive = false;
    public bool enterdButton = false;

    public GameObject timerDisplay;
    public TMP_Text timeText;
    public int countDownTimer;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        animator = GetComponent<Animator>();
        timerDisplay = GameObject.Find("StayTimerDisplay");
        timeText = GetComponentInChildren<TMP_Text>();

        timerDisplay.SetActive(false);
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
            EnableTimer();
            StartCoroutine(StartCountDown());
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        enterdButton = false;
        isButtonActive = false;
        DisableTimer();
        StopAllCoroutines();
        countDownTimer = 3;
    }

    public IEnumerator StartCountDown()
    {
        while (countDownTimer > 0)
        {
            timeText.text = "You wish to stay? " + countDownTimer.ToString();

            yield return new WaitForSeconds(1f);

            countDownTimer--;

        }

        if (countDownTimer == 0)
        {
            gameManager.CutsceneStay();
        }
    }

    public void EnableTimer()
    {
        timerDisplay.SetActive(true);
    }

    public void DisableTimer()
    {
        timerDisplay.SetActive(false);
    }
}



