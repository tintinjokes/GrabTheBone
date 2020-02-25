using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class player_movement : MonoBehaviour
{
    Rigidbody2D rb;
    public Animator animator;

    public float speed;
    public float jumpforce;
    public bool jump = true;
    public float speedboost;
    private TextMeshProUGUI scoreCounterText;
    public int score = 0;
    //public static AudioManager instance;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        scoreCounterText = GetComponent<TextMeshProUGUI>();
        Debug.Log(score);
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        if(Input.GetButtonDown("Fire2") && jump == true)
        {
            jumping();
            animator.SetBool("IsJumping", true);
            animator.SetBool("IsRunning", false);
            
        }

    }

    void jumping()
    {
                rb.AddForce(transform.up * jumpforce, ForceMode2D.Impulse);
                jump = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Ground"))
        {
            jump = true;
            animator.SetBool("IsJumping", false);
            animator.SetBool("IsRunning", true);

        }


        // change to kill the player, pop up game over screen with score and options
        if(collision.gameObject.tag.Equals("Enemy"))
        {
            SceneManager.LoadScene("Level01");
        }

      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("RegularBone"))
        {
            score = score + 5;
            Debug.Log(score);
        }

        if (collision.gameObject.tag.Equals("BigBone"))
        {
            score = score + 10;
            Debug.Log(score);
        }

        if (collision.gameObject.tag.Equals("Steak"))
        {
            speed = speed + speedboost;
        }

        if (collision.gameObject.tag.Equals("FinishBone")) //Temporary, gonna put a pop up menu later on
        {
            SceneManager.LoadScene("Level01");
        }

    }
}