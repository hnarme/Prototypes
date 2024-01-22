using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{
    public GameObject grandpaDialogue;
    public GameObject pressEDialogue;

    public bool isTextShowing = false;
    public bool isTalking = false;

    public Animator animator;

    public GameObject logs;
    public GameObject logText;

    public GameObject exclamation;

    // Update is called once per frame
    void Update()
    {
        if(isTextShowing && Input.GetKeyDown(KeyCode.E))
        {
            grandpaDialogue.SetActive(true);
            pressEDialogue.SetActive(false);
            isTalking = true;
            animator.SetBool("isTalking", isTalking);
            logs.SetActive(true);
            logText.SetActive(true);
            exclamation.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isTextShowing = true;
            pressEDialogue.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isTextShowing = false;
            pressEDialogue.SetActive(false);
            grandpaDialogue.SetActive(false);
            isTalking = false;
            animator.SetBool("isTalking", isTalking);
        }
    }
}
