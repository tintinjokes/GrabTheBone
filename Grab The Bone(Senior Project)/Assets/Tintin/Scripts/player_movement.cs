using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class player_movement : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed;
    public float jumpforce;
    public bool jump = true;
    public float speedboost;

    public int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log(score);
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space) && jump == true)
        {
            jumping();
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
        }


        // change to kill the player, pop up game over screen with score and options
        if(collision.gameObject.tag.Equals("Enemy"))
        {
            SceneManager.LoadScene("TestLevel");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("Small Bone"))
        {
            score = score + 1;
            Debug.Log(score);
        }

        if (collision.gameObject.tag.Equals("Big Bone"))
        {
            score = score + 3;
            Debug.Log(score);
        }

        if (collision.gameObject.tag.Equals("Steak"))
        {
            speed = speed + speedboost;
        }
    }
}