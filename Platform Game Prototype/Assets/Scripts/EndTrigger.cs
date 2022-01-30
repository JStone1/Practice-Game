using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager; // public reference to the game manager script
    public AudioSource sound; // public reference to audio source that is assigned in Unity

    // checks if player enters trigger with the level end object
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.WinLevel(); // runs the win level function in the gamemanager script
        sound.Play(); // plays the winning sound effect
        Time.timeScale = 0f; // freezes the game's time to capture current statistics
    }
}
