using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDown : MonoBehaviour
{

    public float currentTime = 0f;
    public float startingTime = 10f;

    [SerializeField] TextMeshProUGUI countText;
    
    void Start()
    {
        currentTime = startingTime;
    }

    
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countText.text = currentTime.ToString("0");

        if(currentTime <= 3)
        {
            countText.color = Color.red;
        }

        if(currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
