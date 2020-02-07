using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject MainMenuUI;
    public GameObject CreditsUI;
    public GameObject BackButtonUI;
    public GameObject OptionsButtonUI;

    // static bool isLoaded = false;

    // Update is called once per frame
    /*void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)                              // I don't know if I don't want this yet
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    */
    /* public void StartGame()
     {
         MainMenuUI.SetActive(false);
         Time.timeScale = 1f;
         IsPaused = false;
     }

     void Pause()
     {
         pauseMenuUI.SetActive(true);
         Time.timeScale = 0f;
         IsPaused = true;
     }
     */
    


    private void Start()
    {
        
    }
    private void Update()
    {

    }
    public void StartGame()
    {
        //FindObjectOfType<AudioManager>().Play("OnClick");   
        //SceneManager.LoadScene("");
    }

    public void Options()
    {

    }
    public void QuitGame()
    {
        //FindObjectOfType<AudioManager>().Play("OnClick");
        Application.Quit();  
    }
}

