using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public CharacterController controller;
    public Text scoreText;
    public int test;

    // Start is called before the first frame update
    void Start()
    {
        test = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = controller.currentGroundScore.ToString();
    }

    public void updateTest()
    {
        test++;
    }
}
