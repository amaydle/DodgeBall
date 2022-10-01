using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public GameObject scoreUI;
    public GameObject gameOverScreen;
    public GameObject finalScoreUI;
    private TextMeshProUGUI score;
    private TextMeshProUGUI finalScore;
    private int currentScore = 0;

    void Start()
    {
        score = scoreUI.GetComponent<TextMeshProUGUI>();
        finalScore = finalScoreUI.GetComponent<TextMeshProUGUI>();

        InvokeRepeating("UpdateScore", 2.0f, 1);
    }

    void UpdateScore()
    {
        currentScore += 1;
        score.text = "Score: "+ currentScore;
        finalScore.text = "Final Score: "+ currentScore;
    }

    public void GameOver()
    {
        CancelInvoke();
        scoreUI.SetActive(false);
        gameOverScreen.SetActive(true);
    }
}
