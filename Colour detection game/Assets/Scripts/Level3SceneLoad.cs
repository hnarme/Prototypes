using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3SceneLoad : MonoBehaviour
{
    public GameManager gameManager;
    public LogsManager logsManager;
    public PlayerHealthManager playerHealthManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        logsManager = FindObjectOfType<LogsManager>();
        playerHealthManager = FindObjectOfType<PlayerHealthManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Weapon")
        {
            if(logsManager.currentItems == 0)
            {
                gameManager.CutsceneLogCollecting();
            }
            else
            {
                playerHealthManager.StartRespawn();
            }
        }
    }
}
