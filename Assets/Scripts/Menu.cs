using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{    
    public void StartGame()
    {
        SceneManager.LoadScene(1) ;
    }

    public void OpenCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Options()
    {
        SceneTracker.previousSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Options");
    }
    
}
