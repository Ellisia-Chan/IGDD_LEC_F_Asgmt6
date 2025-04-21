using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
    private int score = 0;

    private void Awake() {
        // Load score from PlayerPrefs if it exists
        if (PlayerPrefs.HasKey("Score")) {
            score = PlayerPrefs.GetInt("Score");
        }

        // Add score and show it
        AddScore(10);
        ShowScore();
    }

    // Add score and save it to PlayerPrefs
    public void AddScore(int score) {
        this.score += score;
        PlayerPrefs.SetInt("Score", this.score);
    }

    // Show score
    public void ShowScore() {
        Debug.Log("Score: " + score);
    }
}
