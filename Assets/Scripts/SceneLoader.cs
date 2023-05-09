using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {
     
    }

    public void SceneLoad()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OnQuitButtonClick()
    {
        Application.Quit();
        Debug.Log("Quit");

    }
}
