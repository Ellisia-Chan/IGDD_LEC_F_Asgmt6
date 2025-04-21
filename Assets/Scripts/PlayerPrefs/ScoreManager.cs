using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
    private int score = 0;

    private void Awake() {
        if (PlayerPrefs.HasKey("Score")) {
            score = PlayerPrefs.GetInt("Score");
        }

        AddScore(10);
        ShowScore();
    }

    public void AddScore(int score) {
        this.score += score;
        PlayerPrefs.SetInt("Score", this.score);
    }

    public void ShowScore() {
        Debug.Log("Score: " + score);
    }
}
