using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public GameObject scoreUI;
    public GameObject gameOverScreen;
    public GameObject gameStartScreen;
    public GameObject finalScoreUI;
    private TextMeshProUGUI score;
    private TextMeshProUGUI finalScore;
    private int currentScore = 0;

    void Start()
    {
        score = scoreUI.GetComponent<TextMeshProUGUI>();
        finalScore = finalScoreUI.GetComponent<TextMeshProUGUI>();
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

    public void GameStart(int level)
    {
        gameStartScreen.SetActive(false);
        scoreUI.SetActive(true);
        InvokeRepeating("UpdateScore", 2.0f, 1);
    }
}
