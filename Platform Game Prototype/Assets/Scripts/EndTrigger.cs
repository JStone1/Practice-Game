using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;
    public AudioSource sound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.WinLevel();
        sound.Play();
        Time.timeScale = 0f;
    }
}
