using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text text;
    float time;
    public float speed = 1;
    bool playing = true;
    public string minutes;
    public string seconds;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playing == true)
        {
            time += Time.deltaTime * speed;
            minutes = Mathf.Floor(time % 3600 / 60).ToString("00");
            seconds = (time % 60).ToString("00");
            text.text = minutes + ":" + seconds;
        }
    }

    public void startTimer()
    {
        playing = true;
    }

    public void stopTimer()
    {
        playing = false;
    }
}
