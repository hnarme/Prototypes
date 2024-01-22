using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PauseTimer : MonoBehaviour
{
    public GameObject timerDisplay;
    public Text timeText;
    public int countDownTimer = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator StartCountDown()
    {
        while (countDownTimer > 0)
        {
            timeText.text = "Pausing Game in: " + countDownTimer.ToString();

            yield return new WaitForSeconds(1f);

            countDownTimer--;
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
