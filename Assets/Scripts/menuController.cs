﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour
{
    public string str;

    public void GoToGame()
    {
        SceneManager.LoadScene(str);
    }
}