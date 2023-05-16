using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{

    public float currentTime = 0f;
    [SerializeField] public float startingTime = 180f;

    [SerializeField] TextMeshProUGUI countText;
    
    void Start()
    {
        currentTime = startingTime;
        UpdateCountText();
    }
    
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        if(currentTime <= 30)
        {
            countText.color = Color.red;
        }

        if(currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene("LoseScreen");
        }

        UpdateCountText();

    }

    void UpdateCountText()
    {
        countText.text = currentTime.ToString("0");
    }

}
