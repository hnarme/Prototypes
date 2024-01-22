using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Move left(A) and right(D)
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-1, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(1, 0, 0);
        }
    }
}
