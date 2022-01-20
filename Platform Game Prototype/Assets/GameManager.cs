using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameIsOver = false;

    public void GameOver()
    {
        if (gameIsOver == false)
        {
            gameIsOver = true;
            Debug.Log("GAME OVER");
            Restart();
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}