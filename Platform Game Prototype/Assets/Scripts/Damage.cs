using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    public CharacterController movement;
    public AudioSource playerDeathAudio;
    public AudioSource enemyDeathAudio;
    public GameObject camera;

    private void OnTriggerEnter2D(Collider2D other)
    {
        CharacterController controller = other.GetComponent<CharacterController>();
        if (controller != null)
        {
            controller.ChangeEnemyScore(1);
            enemyDeathAudio.Play();
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            playerDeathAudio.Play();
            Destroy(gameObject);
            camera.SetActive(true);
            FindObjectOfType<GameManager>().GameOver();
            
        }
    }
}
