using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
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
