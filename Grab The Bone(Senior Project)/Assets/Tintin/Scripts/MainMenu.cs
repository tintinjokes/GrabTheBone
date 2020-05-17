using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject MainMenuUI;
    public GameObject CreditsUI;
    public GameObject BackButtonUI;
    public GameObject OptionsButtonUI;
    public GameObject StartButtonUI;
    public GameObject CreditsText;
    //Ronnie's Code 4/27
    public GameObject LevelSelectTitle;
    public GameObject LevelSelect01;
    public GameObject LevelSelect02;
    public Animator animator;

    // static bool isLoaded = false;

    // Update is called once per frame
    //void Update()
    //{
    //  if (Input.GetKeyDown(KeyCode.Escape))
    ///    if (IsPaused)                              // I don't know if I don't want this yet
    //   {
    ///      Resume();
    // }
    //  else
    // {
    //    Pause();
    // }
    //  }
    //}

    //  public void StartGame()
    // {
    //       MainMenuUI.SetActive(false);
    //   Time.timeScale = 1f;
    // IsPaused = false;
    //}

    // void Pause()
    // {
    //    pauseMenuUI.SetActive(true);
    //    Time.timeScale = 0f;
    //    IsPaused = true;
    // }




    private void Start()
    {
        StartButtonUI.SetActive(true);
        OptionsButtonUI.SetActive(true);
        CreditsUI.SetActive(true);
        BackButtonUI.SetActive(false);
        CreditsText.SetActive(false);
        // Ronnie 4/27
        LevelSelectTitle.SetActive(false);
        LevelSelect01.SetActive(false);
        LevelSelect02.SetActive(false);
        
        
    }
    private void Update()
    {

    }
    public void StartGame()
    {
        //FindObjectOfType<AudioManager>().Play("OnClick");   
        //SceneManager.LoadScene("");
    }

    public void BackButton()
    {
        StartButtonUI.SetActive(true);
        OptionsButtonUI.SetActive(true);
        CreditsUI.SetActive(true);
        BackButtonUI.SetActive(false);
        CreditsText.SetActive(false);
        // Ronnie 4/27
        LevelSelectTitle.SetActive(false);
        LevelSelect01.SetActive(false);
        LevelSelect02.SetActive(false);
    }

    public void CreditsButton()
    {
        StartButtonUI.SetActive(false);
        OptionsButtonUI.SetActive(false);
        CreditsUI.SetActive(false);
        BackButtonUI.SetActive(true);
        CreditsText.SetActive(true);
        // Ronnie 4/27
        LevelSelectTitle.SetActive(false);
        LevelSelect01.SetActive(false);
        LevelSelect02.SetActive(false);
    }
    public void Options()
    {
        StartButtonUI.SetActive(false);
        OptionsButtonUI.SetActive(false);
        CreditsUI.SetActive(false);
        BackButtonUI.SetActive(true);
        CreditsText.SetActive(false);
        // Ronnie 4/27
        LevelSelectTitle.SetActive(false);
        LevelSelect01.SetActive(false);
        LevelSelect02.SetActive(false);
    }
    public void LevelSelectScreen()
    {
        StartButtonUI.SetActive(false);
        OptionsButtonUI.SetActive(false);
        CreditsUI.SetActive(false);
        BackButtonUI.SetActive(true);
        CreditsText.SetActive(false);
        // Ronnie 4/27
        LevelSelectTitle.SetActive(true);
        LevelSelect01.SetActive(true);
        LevelSelect02.SetActive(true);
    }
    public void QuitGame()
    {
        //FindObjectOfType<AudioManager>().Play("OnClick");
        Application.Quit();  
    }
}

