using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject tennisball;
    public Transform shootpoint;
    private int tshots;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            if (tshots != 0)
            {
                Fire();
                tshots--;
                ballCounter.ballcount -= 1;
                FindObjectOfType<AudioManager>().Play("ThrownBallSound_03");
            }

            Debug.Log("HEY YOU PRESSED THE FIRE BUTTON");
        }
    }

    void OnTriggerEnter2D(Collider2D token)
    {
       
        Debug.Log(token.gameObject.name);
        
        if(token.gameObject.name == "TennisBallToken")
        {
            tshots = 4;
            Debug.Log("Hey you found a token");
        }
        
        
    }
    void Fire()
    {
        Instantiate(tennisball, shootpoint);
      
    }
}
