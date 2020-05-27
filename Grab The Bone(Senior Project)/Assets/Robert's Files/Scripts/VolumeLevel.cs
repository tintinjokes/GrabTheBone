using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeLevel : MonoBehaviour
{
    public AudioSource audiosrc;
    private void Start()
    {
        audiosrc = GetComponent<AudioSource>();
    }
    void Update()
    {
        audiosrc.volume = PlayerPrefs.GetFloat("Volume Level");
    }
}
