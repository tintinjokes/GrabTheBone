using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public bool isPaused = false;

    public GameObject Pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
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

        if (Input.GetKeyDown(KeyCode.Escape)) //Calls the bool isPaused
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

    

    public void Restart() //Restarts the scene 
    {
        Scene SampleScene;
        SampleScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(SampleScene.name);
    }

    public void MainMenu(string MainMenu) // Main Menu button in the pause menue that calls the level as a string and loads the scene.
    {
        Application.LoadLevel(MainMenu);
    }
}
