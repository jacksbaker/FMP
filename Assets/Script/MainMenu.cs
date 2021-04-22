﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    public string levelToLoad = "LevelSelector";

    public SceneFader sceneFader; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        sceneFader.FadeTo(levelToLoad);

        
        Debug.Log("Play");
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
