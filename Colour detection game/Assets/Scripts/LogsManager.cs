using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LogsManager : MonoBehaviour
{
    public float rotationsPerMinute = 10f;

    public TMP_Text ItemCountText;

    public int currentItems;

    public bool isItemsCollected = false;


    private void Start()
    {
        ItemCountText = GameObject.Find("LogCountText").GetComponent<TMP_Text>();

        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 6.0f * rotationsPerMinute * Time.deltaTime, 0);

        currentItems = GameObject.FindGameObjectsWithTag("Log").Length;

        ItemCountText.text = "Logs to collect: " + currentItems;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Weapon")
        {
            Destroy(gameObject);
        }
    }
}
