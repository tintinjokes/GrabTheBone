using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject tennisball;
    public Transform shootpoint;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) { 
            Fire();
            Debug.Log("HEY YOU PRESSED THE FIRE BUTTON");
        }
    }

    void Fire()
    {
        Instantiate(tennisball, shootpoint);
    }
}
