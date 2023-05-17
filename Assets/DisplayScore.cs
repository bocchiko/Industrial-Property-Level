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
        scoreText.text = score.ToString();
    }

}
