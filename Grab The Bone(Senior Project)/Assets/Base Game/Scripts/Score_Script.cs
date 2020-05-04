using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class Score_Script : MonoBehaviour
{
    TextMeshProUGUI scoreText;
    TextMeshProUGUI highscoreText;
    public static int scorecount = 0;
    public static int highscore = 0;
    

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        highscoreText = GetComponent<TextMeshProUGUI>();
        
    }



    void Update()
    {
        scoreText.text = "Score: " + scorecount;
        
    }

    void UpdateScore()
    {
        if(scorecount > highscore)
        {
            highscore = scorecount;

            highscoreText.text = "Good Boy! Score: " + highscore;

            PlayerPrefs.SetInt("HighScore", highscore);
        }
    }
}

//TextMeshProUGUI ballCounterText;

//public static int ballcount = 0;

//ballCounterText = GetComponent<TextMeshProUGUI>();

//ballCounterText.text = "x " + ballcount;


