using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    private float score;

    void Start()
    {
        highScoreText.text = "High score: " + PlayerPrefs.GetFloat("highscore");
    }

    void Update()
    {
        if (Time.timeScale != 0.0f)
        {
            CheckHighScore();
            score += 0.01f;
            scoreText.text = "Score: " + Mathf.Round(score);
        }
    }

    void CheckHighScore() {
        if (score > PlayerPrefs.GetFloat("highscore")) {
            PlayerPrefs.SetFloat("highscore", Mathf.Round(score));
        }
    }

}
