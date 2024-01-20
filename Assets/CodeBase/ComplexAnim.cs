using UnityEngine;

namespace CodeBase
{
    public class ComplexAnim : MonoBehaviour
    {
        public string soundName;
        private AudioManager audioManager;
        private Animator _animator;

        private void Start()
        {
            audioManager = AudioManager.instance;
            _animator = GetComponent<Animator>();
        }

        private void OnMouseDown()
        {
            if (!_animator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
            {
                PlayAnimation();
                PlaySfx(soundName);
            }
        }

        private void PlayAnimation()
        {
            switchTransition();
        }

        private void PlaySfx(string sound)
        {
            audioManager.Play(sound);
        }

        private void switchTransition()
        {
            if (_animator.GetBool("Open"))
            {
                _animator.SetBool("Open", false);
                _animator.SetBool("Close", true);
            }
            else if (_animator.GetBool("Close"))
            {
                _animator.SetBool("Open", true);
                _animator.SetBool("Close", false);
            }
        }
    }
}