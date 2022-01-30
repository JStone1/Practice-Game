using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Timer time; // reference to timer script
    public CharacterController controller; // reference to character controller script

    // public references to text components assigned in Unity
    public Text groundText;
    public Text enemyText;
    public Text timerText;

    // Update is called once per frame
    void Update()
    {
        // set values of Text components "text" values to the values of the players score - these are displayed to the UI
        groundText.text = controller.currentGroundScore.ToString() + " / " + controller.maxGroundScore.ToString();
        enemyText.text = controller.currentEnemyScore.ToString() + " / " + controller.maxEnemyScore.ToString();
        timerText.text = time.minutes.ToString() + ":" + time.seconds.ToString();
    }
}
