using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Enemy")
    //    {
    //        Debug.Log("Collided with enemy");
    //        Destroy(gameObject);
    //    }
    //}
    private void OnTriggerEnter2D(Collider2D other)
    {
        CharacterController controller = other.GetComponent<CharacterController>();
        if (controller != null)
        {
            controller.ChangeEnemyScore(1);
            Destroy(gameObject);
        }
    }
}
