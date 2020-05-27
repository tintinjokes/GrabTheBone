using System;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[Serializable]
public class Musicadjust : MonoBehaviour
{

    // Reference to Audio Source component
    public AudioSource audioSrc;

    // Music volume variable that will be modified
    // by dragging slider knob
    
    public float musicVolume;

    // Use this for initialization
    
    void Start()
    {
        // Assign Audio Source component to control it
        audioSrc = GetComponent<AudioSource>();

        if(SceneManager.GetActiveScene().name == "Main Menu")
        {
            ResetButton();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Setting volume option of Audio Source to be equal to musicVolume
        audioSrc.volume = musicVolume;
    }

    // Method that is called by slider game object
    // This method takes vol value passed by slider
    // and sets it as musicValue
    public void SetVolume(float vol)
    {
        musicVolume = vol;

    }

    public void ApplyButton()
    {
        PlayerPrefs.SetFloat("Volume Level", musicVolume);

        //Debug.Log(PlayerPrefs.GetFloat("Volume Level"));
    }

    public void ResetButton()
    {
        musicVolume = 1;

        PlayerPrefs.SetFloat("Volume Level", musicVolume);
    }
}