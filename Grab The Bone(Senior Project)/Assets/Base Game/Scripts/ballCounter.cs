using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ballCounter : MonoBehaviour
{
    TextMeshProUGUI ballCounterText;
    public static int ballcount = 0;

    void Start()
    {
        ballCounterText = GetComponent<TextMeshProUGUI>();
    }



    void Update()
    {
         ballCounterText.text = "x" + ballcount;

    }

    void UpdateScore()
    {
        
    }
}
