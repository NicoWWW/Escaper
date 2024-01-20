using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public Text timer;
    private float startTime = -1;
    bool finished = false;


    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 10)
        {
            End();
        }

        if (finished)
        {
            return;
        }

        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timer.text = minutes + ":" + seconds;
    }

    public void End()
    {
        timer.color = Color.red;
        finished = true;
    }

    public void Restart()
    {
        FindObjectOfType<GameManager>().Restart();
    }

}
