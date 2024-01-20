using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayOnClick : MonoBehaviour
{
    public string animName;
    public string soundName;
    private AudioManager audioManager;
    private Animator _animator;
    
    private void Start()
    {
        audioManager = AudioManager.instance;
        if (GetComponent<Animator>() != null)
            _animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        if(!_animator.GetCurrentAnimatorStateInfo(0).IsName(animName))
        {
            PlayAnimation(animName);
            PlaySfx(soundName);
        }
    }

    private void PlayAnimation(string anim)
    {
        _animator.Play(anim);
    }
    private void PlaySfx(string sound)
    {
        audioManager.Play(sound);
    }
}
