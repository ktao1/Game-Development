using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        // get current scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // move to next scene
        if (currentSceneIndex < 2)
        {
            SceneManager.LoadScene(currentSceneIndex += 1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
            
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
