using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class Score_Script : MonoBehaviour
{
    TextMeshProUGUI scoreText;
    public static int scorecount = 0;

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();     
    }

    void Update()
    {
        scoreText.text = "Score: " + scorecount;
    }
}
    

    