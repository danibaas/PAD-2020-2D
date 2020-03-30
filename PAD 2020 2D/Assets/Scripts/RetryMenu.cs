﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryMenu : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene("Level");
    }
       
    public void QuitGame()
    {
        Debug.Log("QuitGame");
        Application.Quit();
    }
}