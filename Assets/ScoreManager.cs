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

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt(ScoreKey, 0);
        scoreText.text = score.ToString();
    }

    public void AddScore()
    {
        score += 10;
        scoreText.text = score.ToString();

        if (score >= 5000)
        {
            PlayerPrefs.SetInt(ScoreKey, score);
            SceneManager.LoadScene("VictoryScreen");
        }
    }
}
