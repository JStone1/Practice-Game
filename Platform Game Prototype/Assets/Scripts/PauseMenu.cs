using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool GamePaused = false; // bool to check if the game is paused

    // public references to gameobjects referenced in Unity - in this case it's the pause menu UI and game stats that are displayed while playing
    public GameObject pauseMenuUI;
    public GameObject inGameStatsUI;

    public AudioSource music; // public reference to an audio source set in Unity

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // checks if escape key is pressed
        {
            if (GamePaused) // checks if bool is set to true - meaning the game is currently paused
            {
                Resume(); // call resume function if game is paused
            }
            else // bool is false
            {
                Pause(); // call pause function if game is not paused
            }
        }
    }

    // function that resumes the game
    public void Resume()
    {
        GamePaused = false; // change bool to false to say game is not paused
        music.Play(); // continue playing game background music
        pauseMenuUI.SetActive(false); // disable the pause menu UI
        inGameStatsUI.SetActive(true); // enable the in game stats UI
        Time.timeScale = 1f; // resume level timer
    }

    // function that pauses the game
    public void Pause()
    {
        GamePaused = true; // change bool to true to say game is paused
        music.Pause(); // pause the audio source (background music)
        pauseMenuUI.SetActive(true); // enable the pause menu UI
        inGameStatsUI.SetActive(false); // disable the in game stats UI
        Time.timeScale = 0f; // freeze time - enemies stop moving and timer pauses
    }
    
    // function that loads the menu screen when player presses button on pause menu
    public void LoadMenu()
    {
        Time.timeScale = 1f; // resumes time
        SceneManager.LoadScene("Menu"); // load the menu scene displaying the main menu to the user
    }

    // function that quits the game when player presses button on pause menu
    public void QuitGame()
    {
        Debug.Log("Qutting game"); // checks the quit function is working by printing to console
        Application.Quit(); // quits the application
    }

    // function that restarts the level when player presses button
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // gets the name of the current scene and loads it, therefore starting from the beginning of the level
        Time.timeScale = 1f; // resumes time
    }
}
