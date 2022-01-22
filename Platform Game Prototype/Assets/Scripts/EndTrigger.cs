using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.WinLevel();
        Time.timeScale = 0f;
    }
}
