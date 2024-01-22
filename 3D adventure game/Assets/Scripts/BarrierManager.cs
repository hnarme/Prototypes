using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierManager : MonoBehaviour
{
    GameManager gameManager;
    public int Items;

    // Start is called before the first frame update
    void Start()
    {
        Items = FindObjectOfType<GameManager>().getNumOfItems();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && Items > 0)
        {
            Debug.Log("Collect all items first");
        }
    }
}


