using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool isPaused;
    public GameObject Pause;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (isPaused)                    //If/Else statements determine if the game paused or not and determines a reaction time for each one
        {
            Pause.SetActive(true);
            Time.timeScale = 0f;
        }
        
        else
        {
            Pause.SetActive(false);
            Time.timeScale = 1f;
        }

        if (collision.gameObject.tag.Equals("Tutorial")) //Calls the bool isPaused
        {
            isPaused = !isPaused;
        }
    }

    public void Continue() //Closes the pause menu and unfreezes time after being clicked.
    {
        Pause.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void OnPause()
    {
        if (isPaused)                    //If/Else statements determine if the game paused or not and determines a reaction time for each one
        {
            Pause.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            Pause.SetActive(false);
            Time.timeScale = 1f;
        }
        isPaused = !isPaused;
    }
   

}
