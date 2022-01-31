using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{

    // public variables to refer to the UI screens assigned in Unity
    public GameObject story;
    public GameObject menu;

    // function that triggers when player presses start on main menu screen
    public void DisplayInfo()
    {
        menu.SetActive(false); // sets main menu screen to false which hides it from view
        story.SetActive(true); // sets the info/story screen to true so player can view it
    }

    // function that loads the level when player presses play
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // loads the next scene in the build index - in this case it is the first level

    }
    
    // function that quits the game when player presses exit
    public void QuitGame()
    {
        Debug.Log("Game quit"); // checks the quit function is working by printing to console
        Application.Quit(); // quits the application
    }
}
