using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameIsOver = false;

    public float restartDelay = 1f;

    public GameObject winScreenUI;
    public GameObject inGameStatsUI;
    public GameObject deathUI;
    public WinUI win;
    public AudioSource sound;

    public void WinLevel ()
    {
        winScreenUI.SetActive(true);
        inGameStatsUI.SetActive(false);
    }

    public void GameOver()
    {
        if (gameIsOver == false)
        {
            gameIsOver = true;
            Debug.Log("GAME OVER");
            sound.Play();
            inGameStatsUI.SetActive(false);
            deathUI.SetActive(true);
            Invoke("Restart", restartDelay);
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}