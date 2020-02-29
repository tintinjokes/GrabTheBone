using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score_Script : MonoBehaviour
{
    
    public Transform player;
    public static int scorecount;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scorecount = 0;
    }

    // public int score = 0;

    void Update()
    {
        //scoreText.text = scorecount.ToString();
    }

    //Still a work in progross
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            scorecount += 5;
            Debug.Log(scorecount);
        }

        if (collision.gameObject.tag.Equals("Player"))
        {
            scorecount += 10;
            Debug.Log(scorecount);
        }

    }
    
}