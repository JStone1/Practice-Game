using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool IsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject inGameStatsUI;

    public AudioSource music;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        IsPaused = false;
        music.Play();
        pauseMenuUI.SetActive(false);
        inGameStatsUI.SetActive(true);
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        IsPaused = true;
        music.Pause();
        pauseMenuUI.SetActive(true);
        inGameStatsUI.SetActive(false);
        Time.timeScale = 0f;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Qutting game");
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}
