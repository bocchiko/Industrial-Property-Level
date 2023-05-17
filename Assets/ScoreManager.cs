using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    [SerializeField] public TextMeshProUGUI scoreText;

    public int score = 0;
    private const string ScoreKey = "Score";

    private float currentTime;
    private const string CurrentTimeKey = "CurrentTime";

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        score = 0;
        
        UpdateScoreText();

        currentTime = PlayerPrefs.GetFloat(CurrentTimeKey, 0f);
    }

    public void AddScore()
    {
        score += 10;
        UpdateScoreText();

        if (score >= 300)
        {
            int additionalScore = (int)(currentTime * 100);
            score += additionalScore;

            PlayerPrefs.SetInt(ScoreKey, score);
            PlayerPrefs.SetInt("AdditionalScore", additionalScore);
            SceneManager.LoadScene("VictoryScreen");
        }
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetFloat(CurrentTimeKey, currentTime);
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

}