using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeBehaviour : MonoBehaviour
{
    public Sprite normalBee;
    public Sprite angryBee;
    public healthManager health;

    private SpriteRenderer SpriteRenderer;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            CircleCollider2D coll = gameObject.GetComponent<CircleCollider2D>();

            if (coll.OverlapPoint(mousePos))
            {
                if (coll.gameObject.CompareTag("Bee"))
                {
                    if (this.gameObject.GetComponent<SpriteRenderer>().sprite == normalBee)
                    {
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = angryBee;
                        
                            health.SubtractHealth();
                    }
                }
            }
        }

    }
}
