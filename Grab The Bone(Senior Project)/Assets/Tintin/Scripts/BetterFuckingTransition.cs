using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BetterFuckingTransition : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator animator;
    public Button Level1;
    public Button Level2;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeToLevel()
    {
        animator.SetTrigger("Start");



    }
}
