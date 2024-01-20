using System;
using UnityEngine;
using UnityEngine.UI;

namespace CodeBase
{
    public class PlayButtonOnClick : MonoBehaviour
    {
        public Button sceneButton;

        private void OnMouseDown()
        {
            sceneButton.onClick?.Invoke();
        }
    }
}