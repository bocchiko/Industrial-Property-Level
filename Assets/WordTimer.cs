using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour
{
    public WordManager wordManager;

    public float wordDelay = 0.50f;
    private float nextTime = 0f;

    private void Update()
    {
        if(Time.time >= nextTime)
        {
            wordManager.AddWord();
            nextTime = Time.time + wordDelay;
            wordDelay *= 1f;
        }
    }
}
