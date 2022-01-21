using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Timer time;
    public CharacterController controller;

    public Text groundText;
    public Text enemyText;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        groundText.text = controller.currentGroundScore.ToString() + " / " + controller.maxGroundScore.ToString();
        enemyText.text = controller.currentEnemyScore.ToString() + " / " + controller.maxEnemyScore.ToString();
        timerText.text = time.minutes.ToString() + ":" + time.seconds.ToString();
    }
}
