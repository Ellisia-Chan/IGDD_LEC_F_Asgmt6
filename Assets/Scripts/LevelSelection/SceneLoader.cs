using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace LevelSelection {
    public class SceneLoader : MonoBehaviour {

        [SerializeField] private Button level1;
        [SerializeField] private Button level2;
        [SerializeField] private Button level3;

        private void Awake() {
            // add listeners to buttons
            level1.onClick.AddListener(() => { LoadLevel("Level1"); });
            level2.onClick.AddListener(() => { LoadLevel("Level2"); });
            level3.onClick.AddListener(() => { LoadLevel("Level3"); });
        }
        // load level
        public void LoadLevel(string sceneName) {
            SceneManager.LoadScene(sceneName);
        }
    }
}
