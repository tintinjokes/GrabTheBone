using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingMechanic : MonoBehaviour
{
    private Vector2 beginTouchPosition, endTouchPosition;
    private Rigidbody2D rb;
    private float jumpForce = 400f;
    private bool jumpMade = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        SwipeCheck();
    }
    void FixedUpdate()
    {
        jumpIfMade();
    }

    void SwipeCheck()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            beginTouchPosition = Input.GetTouch(0).position;

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;

            if (endTouchPosition.y > beginTouchPosition.y && rb.velocity.y == 0)
                jumpMade = true;
        }
    }

    void jumpIfMade()
    {
        if (jumpMade)
        {
            rb.AddForce(Vector2.up * jumpForce);
            jumpMade = false;
            /*
            AudioManager.instance.PlaySFX(1);
            */
        }
    }
}
