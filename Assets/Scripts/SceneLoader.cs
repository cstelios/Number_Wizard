﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if(currentSceneIndex == 2)
        {
            SceneManager.LoadScene(0);
        } 
        else
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
