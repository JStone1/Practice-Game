using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameIsOver = false; // bool to check if game is over

    public float restartDelay = 1f; // public variable that stores the value of how long the game restarts after dying

    // public variables to refer to the UI screens assigned in Unity
    public GameObject winScreenUI;
    public GameObject inGameStatsUI;
    public GameObject deathUI;

    public AudioSource sound; // public reference to an audio source set in Unity

    // function that runs when player completes level
    public void WinLevel ()
    {
        winScreenUI.SetActive(true); // displays the level complete UI
        inGameStatsUI.SetActive(false); // disable the in game stats UI
    }

    // function that runs when player dies
    public void GameOver()
    {
        if (gameIsOver == false) // checks if game is over
        {
            gameIsOver = true; // set bool to true - player has died
            sound.Play(); // play the player death sound
            inGameStatsUI.SetActive(false); // disable the in game stats UI
            deathUI.SetActive(true); // enable the death screen UI
            Invoke("Restart", restartDelay); // invoke the restart function after a specified time - this value is declared in the restartDelay variable
        }

    }

    // function that restarts the level
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // gets the name of the current scene and loads it, therefore starting from the beginning of the level
    }
}