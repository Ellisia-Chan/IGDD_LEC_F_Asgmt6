using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SceneTransition {

    public class SceneLoader : MonoBehaviour {

        private void Start() {
            LoadNextScene("Level1");
        }

        // Load next scene
        public void LoadNextScene(string sceneName) {
            SceneManager.LoadScene(sceneName);
        }
    }
}