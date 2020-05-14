using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;
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
    public LayerMask uiLayer;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

 

    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0) && MouseOverUI())
        {
            Debug.Log("MouseOverUI called");
            return;
        }
        else if (Input.GetMouseButtonDown(0) && !MouseOverUI())
        {
            if (jump == true)
            {
                rb.AddForce(transform.up * jumpforce, ForceMode2D.Impulse);
                jump = false;

                animator.SetBool("IsJumping", true);
                animator.SetBool("IsRunning", false);
                FindObjectOfType<AudioManager>().Play("Jump5");
            }
            Debug.Log("!MouseOverUI called");
        }
    }
    
    private bool MouseOverUI()
    {
        return EventSystem.current.IsPointerOverGameObject(uiLayer);
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

        if (collision.gameObject.tag.Equals("TEnemy"))
        {
            SceneManager.LoadScene("Tutorial_Level");
            Score_Script.scorecount = 0;
            ballCounter.ballcount = 0;
        }

        if (collision.gameObject.tag.Equals("Enemy"))
        {
            SceneManager.LoadScene("Level01");
            Score_Script.scorecount = 0;
            ballCounter.ballcount = 0;
        }

        if (collision.gameObject.tag.Equals("Enemy2"))
        {
            SceneManager.LoadScene("Level02");
            Score_Script.scorecount = 0;
            ballCounter.ballcount = 0;
        }

        if (collision.gameObject.tag.Equals("Enemy3"))
        {
            SceneManager.LoadScene("Level03");
            Score_Script.scorecount = 0;
            ballCounter.ballcount = 0;
        }

        if (collision.gameObject.tag.Equals("BEnemy"))
        {
            SceneManager.LoadScene("Bonus_Level");
            Score_Script.scorecount = 0;
            ballCounter.ballcount = 0;
        }

    }

    //Comeback to update SCORE:0
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag.Equals("RegularBone"))
        {
            Score_Script.scorecount += 5;
            FindObjectOfType<AudioManager>().Play("nice Bite Sound Effect");
        }

        if (collision.gameObject.tag.Equals("BigBone"))
        {
            Score_Script.scorecount += 10;
            FindObjectOfType<AudioManager>().Play("nice Bite Sound Effect");
        }

        if (collision.gameObject.tag.Equals("Steak"))
        {
            speed = speed + speedboost;
            FindObjectOfType<AudioManager>().Play("Eat Munch 2 Sound Effect (download)");
        }

        if (collision.gameObject.tag.Equals("Ball"))
        {
            ballCounter.ballcount += 1;
        }

        
        if (collision.gameObject.tag.Equals("FinishBone")) 
        {
            Score_Script.scorecount += Score_Script.highscore;
        }

        if (collision.gameObject.tag.Equals("FinishBone2"))
        {
            Score_Script.scorecount += Score_Script.highscore;
        }

    }
}