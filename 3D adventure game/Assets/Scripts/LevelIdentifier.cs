using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelIdentifier : MonoBehaviour
{
    public int level;
    //Scene scene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "Tutorial - Town")
        {
            level = 0;
        }
        else if (scene.name == "Level 1 - Circle World")
        {
            level = 1;
        }
        else if (scene.name == "Level 2 - Thief's Trail")
        {
            level = 2;
        }
        else if (scene.name == "Level 3 - Climb")
        {
            level = 3;
        }
        else if (scene.name == "Level 4 - Castle")
        {
            level = 4;
        }
    }
}
