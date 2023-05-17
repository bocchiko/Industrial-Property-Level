using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Start()
    {
        int score = PlayerPrefs.GetInt("Score", 0);
        int additionalScore = PlayerPrefs.GetInt("AdditionalScore", 0);
        scoreText.text = "Your Score: " + score.ToString() + "\nAdditional Score: " + additionalScore.ToString();
    }

}
