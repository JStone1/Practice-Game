using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    // public references to audio sources that are assigned in Unity
    public AudioSource playerDeathAudio; 
    public AudioSource enemyDeathAudio;

    public GameObject camera; // public reference to a camera object assigned in Unity - death camera

    // function that checks if a trigger is entered (enemy's head) and kills the enemy
    private void OnTriggerEnter2D(Collider2D other)
    {
        CharacterController controller = other.GetComponent<CharacterController>(); // assign variable to the character controller script
        if (controller != null)
        {
            controller.ChangeEnemyScore(1); // adds 1 to player's enemy score
            enemyDeathAudio.Play(); // plays the enemy death audio assigned in Unity
            Destroy(gameObject); // destroys the enemy game object
        }
    }

    // function that checks if the player enters a collision (enemy's body) and kills the player
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy") // checks if player is colliding with object with "enemy" assigned
        {
            playerDeathAudio.Play(); // plays the player death sound assigned in Unity
            Destroy(gameObject); // destroys player game object
            camera.SetActive(true); // sets the death camera to true to display a death screen
            FindObjectOfType<GameManager>().GameOver(); // runs the game over function in the game manager
            
        }
    }
}
