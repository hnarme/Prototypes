using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

    private scoreManager scoreManager;

    // Use this for initialization
    void Start ()
    {
        gameObject.SetActive(true);
        scoreManager = GameObject.FindWithTag("Fly").GetComponent<scoreManager>();
    }

	void FixedUpdate()
	{

	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            CircleCollider2D coll = gameObject.GetComponent<CircleCollider2D>();

            if (coll.OverlapPoint(mousePos))
            {
                if (coll.gameObject.CompareTag("Fly"))
                {
                    scoreManager.subtractScore();
                    coll.gameObject.SetActive(false);                 
                }
            }
        }
    }
}
