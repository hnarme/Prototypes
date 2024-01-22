using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonMovementV2 : MonoBehaviour
{
    public EndlessGameManager gameManager;

    public int speed;
    public int colourNum;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        gameManager = FindObjectOfType<EndlessGameManager>();
        //currentSpeed();

        rb.velocity = new Vector2(0, +speed);

        UpdatespeedLevel();

        colourNum = Random.Range(0, 5);

        //if (colourNum == 0)
        //{
        //    transform.Find("red balloon").gameObject.SetActive(true);
        //}
        //else if (colourNum == 1)
        //{
        //    transform.Find("yellow balloon").gameObject.SetActive(true);
        //}
        //else if (colourNum == 2)
        //{
        //    transform.Find("orange balloon").gameObject.SetActive(true);
        //}
        //else if (colourNum == 3)
        //{
        //    transform.Find("green balloon").gameObject.SetActive(true);
        //}
        //else if (colourNum == 4)
        //{
        //    transform.Find("blue balloon").gameObject.SetActive(true);
        //}
        //else if (colourNum == 5)
        //{
        //    transform.Find("black balloon").gameObject.SetActive(true);
        //}
    }

    public int currentSpeed()
    {
        return speed;
    }

    public int UpdatespeedLevel()
    {
        speed = 10 + gameManager.GetComponent<EndlessGameManager>().level;
        return speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "popzone")
        {
            gameObject.SetActive(false);
        }
    }
}
