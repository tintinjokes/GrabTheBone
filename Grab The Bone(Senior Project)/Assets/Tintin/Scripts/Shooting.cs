using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Shooting : MonoBehaviour
{
    public GameObject tennisball;
    public Transform shootpoint;
    public LayerMask uiShootLayer;
    private int tshots;
    
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && MouseOverUI())
        {
            if (tshots != 0)
            {
                Instantiate(tennisball, shootpoint);
                tshots--;
                ballCounter.ballcount -= 1;
                FindObjectOfType<AudioManager>().Play("ThrownBallSound_03");
            }

            Debug.Log("MouseOverUI, shot fired");
        }

        else if (Input.GetMouseButtonDown(0) && !MouseOverUI())
        {
            Debug.Log("!MouseOverUI");
        }
    }

    void OnTriggerEnter2D(Collider2D token)
    {
       
        Debug.Log(token.gameObject.name);
        
        if(token.gameObject.name == "TennisBallToken")
        {
            tshots += 1;
            Debug.Log("Hey you found a token");
        }
        
        
    }
    private bool MouseOverUI()
    {
        return EventSystem.current.IsPointerOverGameObject(uiShootLayer);
    }
}
