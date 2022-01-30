using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScore : MonoBehaviour
{
    public AudioSource sound; // public reference to audio source that is assigned in Unity

    // checks for a trigger - in this case it is the ground
    private void OnTriggerEnter2D(Collider2D other)
    {
        CharacterController controller = other.GetComponent<CharacterController>(); // assign variable to the character controller script
        if (controller != null)
        {
            sound.Play(); // plays the sound of the ground changing when walked over
            controller.ChangeGroundScore(1); // adds 1 to the the players ground score
            Destroy(gameObject); // destroys the alive grass object
        }
    }
}
