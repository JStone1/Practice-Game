using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameIsOver = false;

    public float restartDelay = 1f;

    public GameObject winScreenUI;
    public WinUI win;

    public void WinLevel ()
    {
        winScreenUI.SetActive(true);
        win.displayScore();
    }

    public void GameOver()
    {
        if (gameIsOver == false)
        {
            gameIsOver = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}