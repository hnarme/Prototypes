using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorYELLOW : MonoBehaviour
{
    public UDPPortControllerYELLOW UDPPortController;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Remove brackets, add coordinates to an array, Move the objects x and y values 
    void Update()
    {
        string data = UDPPortController.message; //get object coordinates from UDPPortController
        data = data.Remove(0, 1);
        data = data.Remove(data.Length - 1, 1); //removing second bracket
        string[] info = data.Split(','); //split the data by the comma

        float x = 5 - float.Parse(info[0]) / 100;
        float y = float.Parse(info[1]) / 100;
        float z = -10 + float.Parse(info[2]) / 1000;

        gameObject.transform.localPosition = new Vector3(x, y, z);
    }
}
