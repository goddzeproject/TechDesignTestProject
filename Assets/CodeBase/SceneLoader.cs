using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CodeBase
{
    public class SceneLoader : MonoBehaviour
    {
        public void loadNextScene(int sceneId)
        {
            SceneManager.LoadScene(sceneId);
        }
    }
}