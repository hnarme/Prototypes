﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartScene : MonoBehaviour {

    public void Resetscene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
