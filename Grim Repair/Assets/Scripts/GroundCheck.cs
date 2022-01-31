using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool isOnTheGround; // boolean to check if player is touching the ground

    // checks for collision
    private void OnCollisionStay2D(Collision2D collision)
    {
        // checks if player collision makes contact with a gameobject tagged "Ground"
        if (collision.gameObject.tag == "Ground")
        {
            isOnTheGround = true; // set bool to true - therefore allowing player to jump
        }
    }

    // checks for collision exit
    private void OnCollisionExit2D(Collision2D collision)
    {
        // checks if player collision leaves contact with a gameobject tagged "Ground"
        if (collision.gameObject.tag == "Ground")
        {
            isOnTheGround = false; // set bool to false - therefore player cannot jump as they are already airborne
        }
    }

}
