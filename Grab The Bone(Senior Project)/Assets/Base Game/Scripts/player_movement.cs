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
    public TextMeshProUGUI scoreCounterText;
    public int score = 0;
    [SerializeField]

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        scoreCounterText = GetComponent<TextMeshProUGUI>();
        Debug.Log(score);
        animator = GetComponent<Animator>();
    }

    void Update()
    {
      
    }

    private void FixedUpdate()
    {

        transform.Translate(Vector2.right * speed * Time.deltaTime);

        if(Input.GetButtonDown("Fire2") && jump == true)
        {
            jumping();
            animator.SetBool("IsJumping", true);
            animator.SetBool("IsRunning", false);
            FindObjectOfType<AudioManager>().Play("Jump5");
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

    //Comeback to update SCORE:0
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag.Equals("RegularBone"))
        {        
            score = score + 5;
            Debug.Log(score);
            FindObjectOfType<AudioManager>().Play("nice Bite Sound Effect");
        }

        if (collision.gameObject.tag.Equals("BigBone"))
        {
            score = score + 10;
            Debug.Log(score);
            FindObjectOfType<AudioManager>().Play("nice Bite Sound Effect");
        }

        if (collision.gameObject.tag.Equals("Steak"))
        {
            speed = speed + speedboost;
            FindObjectOfType<AudioManager>().Play("Eat Munch 2 Sound Effect (download)");
        }

        if (collision.gameObject.tag.Equals("FinishBone")) //Temporary, gonna put a pop up menu later on
        {
            SceneManager.LoadScene("Level01");
        }
        
    }
}