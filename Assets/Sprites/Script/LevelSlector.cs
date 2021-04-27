using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSlector : MonoBehaviour
{
    public string levelToLoad;

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
}
