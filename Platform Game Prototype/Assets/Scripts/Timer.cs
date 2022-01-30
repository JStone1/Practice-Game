using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text text; // public reference to the text component in the UI set in Unity
    float time; // variable to store the time
    public float speed = 1; // public variable to change speed of the timer
    bool playing = true; // bool to check if the game is playing
    public string minutes; // varibale to store minutes
    public string seconds; // varibale to store seconds

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>(); // assigns text variable 
    }

    // Update is called once per frame
    void Update()
    {
        if (playing == true) // checks if bool is true
        {
            time += Time.deltaTime * speed; // set time variable to deltatime * the value of the speed variable - in normal cases this is "1"
            minutes = Mathf.Floor(time % 3600 / 60).ToString("00"); // calcualtion to get the minutes and convert it to string
            seconds = (time % 60).ToString("00"); // calcualtion to get the seconds and convert it to string
            text.text = minutes + ":" + seconds; // make the text component "text" value equal to the minutes and seconds variables
        }
    }

    // function that starts the timer
    public void startTimer()
    {
        playing = true; // set bool to true meaning the game is playing
    }

    // function that stops the timer
    public void stopTimer()
    {
        playing = false; // set bool to false meaning the game is not playing
    }
}
