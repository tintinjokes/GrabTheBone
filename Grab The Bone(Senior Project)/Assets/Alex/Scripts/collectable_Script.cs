using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable_Script : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
