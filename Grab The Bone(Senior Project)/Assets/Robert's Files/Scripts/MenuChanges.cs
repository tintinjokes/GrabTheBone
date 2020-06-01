using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenuChanges : MonoBehaviour
{
    public GameObject mainMenuCanvas;
    public GameObject levelCanvas;
    public GameObject optionsCanvas;


    private void Start()
    {
        mainMenuCanvas.SetActive(true);
        levelCanvas.SetActive(false);
        optionsCanvas.SetActive(false);
    }



    public void PressStart()
    {
        levelCanvas.SetActive(true);
        mainMenuCanvas.SetActive(false);
    }



    public void PressOptions()
    {
        optionsCanvas.SetActive(true);
        mainMenuCanvas.SetActive(false);
    }


    public void PressBack()
    {
        if(levelCanvas)
        {
            mainMenuCanvas.SetActive(true);
            levelCanvas.SetActive(false);
        }

        if(optionsCanvas)
        {
            mainMenuCanvas.SetActive(true);
            optionsCanvas.SetActive(false);
        }
    }

/* Changed by Ronnie 5/19/20
    public void LevelSelect(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
*/
}

