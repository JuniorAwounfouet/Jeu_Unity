using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSrc, sfxSrc;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        PlayMusic(SoundName.Intro);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayMusic(string name, bool loop = true)
    {
        Sound s = Array.Find(musicSounds, e => e.name == name);

        if (s == null)
        {
            Debug.Log("No music found.");
        }
        else
        {
            musicSrc.Stop();
            musicSrc.clip = s.clip;
            musicSrc.loop = loop;
            musicSrc.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, e => e.name == name);

        if (s == null)
        {
            Debug.Log("No sfx found.");
        }
        else
        {
            sfxSrc.PlayOneShot(s.clip);
        }
    }
}
