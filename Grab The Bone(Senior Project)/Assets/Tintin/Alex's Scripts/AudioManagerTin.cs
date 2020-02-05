using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioClip[] sfxClips;
    public AudioSource sfxAudioSource;
    [Range(0, 1)] public float sfxVolume = 1f;

    public AudioClip[] bgmClips;
    public AudioSource bgmAudioSource;
    [Range(0, 1)] public float bgmVolume = 0.5f;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        PlayBGM(0);
    }

    // Update is called once per frame
    void Update()
    {
        sfxAudioSource.volume = sfxVolume;
        bgmAudioSource.volume = bgmVolume;
    }

    public void PlaySFX(int clip)
    {
        sfxAudioSource.PlayOneShot(sfxClips[clip]);
        Debug.Log("Song is Played.");
    }

    public void PlayBGM(int clip)
    {
        bgmAudioSource.Stop();
       // bgmAudioSource.clip = bgmClips[clip];
        bgmAudioSource.Play();
        Debug.Log("This is Playing");
    }
    
    public void SFXVolume(float vol) //Adjusts the volume for SFX using the slider in the sound test menu.
    {
        sfxVolume = vol;
        Debug.Log("The Volume is being changed");
    }

    public void BGMVolume(float vol) //Adjusts the volume for BGM using the slider in the sound test menu
    {
        bgmVolume = vol;
        Debug.Log("The volume is being changed");
    }
}
