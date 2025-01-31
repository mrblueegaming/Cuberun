﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public GameObject completeLevelUI;
    public PlayerMovement movement;


    public void EndGame()
    {        
        if (!gameHasEnded)
        {
            gameHasEnded = true;            
            Debug.Log("GAME OVER");
            Invoke("Restart", 2f);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        Input.ResetInputAxes();
        completeLevelUI.SetActive(true);
        Invoke("LoadNextLevel", 4f);        
    }    

    void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
