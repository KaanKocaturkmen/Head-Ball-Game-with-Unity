using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time, timeGiven;
    public Text timeText;

    void Start()
    {
        time = timeGiven;

    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = time.ToString("f2");
        time -= Time.deltaTime;
        if (time <= 0) { Application.LoadLevel(Application.loadedLevel); }
    }
}
