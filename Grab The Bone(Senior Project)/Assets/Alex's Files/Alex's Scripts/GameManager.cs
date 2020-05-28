using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        int CurrentLevel = currentScene.buildIndex;
        int levelPassed = PlayerPrefs.GetInt("LevelPassed");
        if (levelPassed < CurrentLevel)
            PlayerPrefs.SetInt("LevelPassed", CurrentLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        Time.timeScale = 1f;
        Score_Script.scorecount = 0;
        ballCounter.ballcount = 0;
    }

    public void Restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        Score_Script.scorecount = 0;
        ballCounter.ballcount = 0;
    }


        public void QuitApplication()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

}
