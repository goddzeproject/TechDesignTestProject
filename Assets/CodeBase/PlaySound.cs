using System;
using UnityEngine;

namespace CodeBase
{
    public class PlaySound : MonoBehaviour
    {
        public string soundName;
        private AudioManager audioManager;

        private void Start()
        {
            audioManager = AudioManager.instance;
        }

        private void OnMouseDown()
        {
            audioManager.Play(soundName);
        }
    }
}