using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject howToPlayUI;

    public Text ItemCountText;

    public int currentItems;

    public GameObject Barrier1;

    public Animator m_Animator;

    public bool isItemsCollected = false;

    public string tutorialScene;

    public string Level4Scene;

    // Update is called once per frame
    void Update()
    {
        if(howToPlayUI.activeInHierarchy)
        {
            Time.timeScale = 0;

            if (Input.anyKeyDown)
            {
                howToPlayUI.SetActive(false);
                Time.timeScale = 1;
            }
        }
        else if(!howToPlayUI.activeInHierarchy)
        {
        }

        RemoveBarrier();

        currentItems = GameObject.FindGameObjectsWithTag("Item").Length;

        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == tutorialScene)
        {
            ItemCountText.text = "Logs to collect: " + currentItems;
        }
        else if (scene.name == Level4Scene)
        {
            ItemCountText.text = "Keys to Collect: " + currentItems;
        }
        else
        {
            ItemCountText.text = "Gems Left: " + currentItems;
        }

        if (currentItems == 0)
        {
            isItemsCollected = true;
        }

        m_Animator.SetBool("isItemsCollected", isItemsCollected);
    }

    public int PickedUpItems()
    {
        return currentItems;
    }

    public int getNumOfItems()
    {
        return currentItems;
    }

    public void RemoveBarrier()
    {
        if (currentItems == 0)
        {
            Destroy(Barrier1);
        }
    }

    public void OpenDoor()
    {
        if (currentItems == 0)
        {
            isItemsCollected = true;
        }
    }

    public void OpenGate()
    {
        if (currentItems == 0)
        {
            isItemsCollected = true;
        }
    }
}


