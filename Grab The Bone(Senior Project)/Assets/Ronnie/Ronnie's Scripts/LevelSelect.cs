using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public Button level01button, level02button, level03button, bonusLevelButton;
    int levelPassed;

    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        level01button.interactable = true;
        level02button.interactable = false;
        level03button.interactable = false;
        bonusLevelButton.interactable = false;

        switch (levelPassed)
        {
            case 1:
                level01button.interactable = true;
                break;
            case 2:
                level01button.interactable = true;
                level02button.interactable = true;
                break;
            case 3:
                level01button.interactable = true;
                level02button.interactable = true;
                level03button.interactable = true;
                break;
            case 4:
                level01button.interactable = true;
                level02button.interactable = true;
                level03button.interactable = true;
                bonusLevelButton.interactable = true;
                break;
        }
    }

    public void LevelLoad (int level)
    {
        SceneManager.LoadScene(level);
    }

    public void GameReset()
    {
        level01button.interactable = false;
        level02button.interactable = false;
        level03button.interactable = false;
        bonusLevelButton.interactable = false;
        PlayerPrefs.DeleteAll();
    }

    /* add later to level win script
    if LevelPassed < sceneIndex)
        PlayerPrefs.SetInt("LevelPassed", sceneIndex);
    */
}
