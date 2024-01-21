﻿using System;
using CodeBase;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public Sounds[] Sounds;

    public string MainTheme;
    public string ambient;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        //DontDestroyOnLoad(gameObject);

        foreach(Sounds sound in Sounds)
        {
            sound.AudioSource = gameObject.AddComponent<AudioSource>();
            sound.AudioSource.clip = sound.clip;

            sound.AudioSource.volume = sound.Volume;
            sound.AudioSource.pitch = sound.Pitch;
            sound.AudioSource.loop = sound.Loop;
        }
    }

    private void Start()
    {
        Play(MainTheme);
        Play(ambient);
    }

    public void Play(string SoundName)
    {
        Sounds s = Array.Find(Sounds, Sounds => Sounds.Name == SoundName);
        if (s == null)
        {
            return;
        }
        s.AudioSource.Play();

    }


}