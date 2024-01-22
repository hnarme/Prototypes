using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBalloonMovement : MonoBehaviour
{
    public LevelGameManager levelGameManager;

    public int speed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        levelGameManager = FindObjectOfType<LevelGameManager>();
        //currentSpeed();

        rb.velocity = new Vector2(0, +speed);

        UpdatespeedLevel();
    }

    public int currentSpeed()
    {
        return speed;
    }

    public int UpdatespeedLevel()
    {

        switch (levelGameManager.GetComponent<LevelGameManager>().level)
        {
            case 1:
                {
                    speed = 12;
                }
                break;
            case 2:
                {
                    speed = 15;
                }
                break;
            case 3:
                {
                    speed = 18;
                }
                break;
            case 4:
                {
                    speed = 21;
                }
                break;
            case 5:
                {
                    speed = 24;
                }
                break;
            case 6:
                {
                    speed = 27;
                }
                break;
            case 7:
                {
                    speed = 30;
                }
                break;
            case 8:
                {
                    speed = 45;
                }
                break;
            case 9:
                {
                    speed = 50;
                }
                break;
            case 10:
                {
                    speed = 55;
                }
                break;
            case 11:
                {
                    speed = 60;
                }
                break;
            case 12:
                {
                    speed = 65;
                }
                break;
            case 13:
                {
                    speed = 70;
                }
                break;
            case 14:
                {
                    speed = 42;
                }
                break;
            case 15:
                {
                    speed = 45;
                }
                break;
            case 16:
                {
                    speed = 48;
                }
                break;
            case 17:
                {
                    speed = 51;
                }
                break;
            case 18:
                {
                    speed = 54;
                }
                break;
            case 19:
                {
                    speed = 57;
                }
                break;
            case 20:
                {
                    speed = 60;
                }
                break;
            default:
                {
                    speed = 3;
                }
                break;
        }

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
