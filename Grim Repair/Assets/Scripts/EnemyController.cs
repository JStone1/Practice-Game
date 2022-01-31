using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed; // public variable to control speed
    public float changeTime = 1.0f; // variable to change how often the enemy moves in a line

    Rigidbody2D rb2D; // reference to the objects RigidBody2D - in this case it is the enemy
    float timer; // variable to store the timer
    int direction = 1; // variable to store the value of enemy moving - positive value means it will move right, negative will move left

    
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>(); // assigns variable to the objects RigidBody2D
        timer = changeTime; // sets initial value of timer equal to the value assinged to the changeTime variable
    }

    private void Update()
    {
        timer -= Time.deltaTime; // deltaTime is the time in seconds between the last and current frame

        // if timer value is below 0 then change the direction of the enemy
        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        }
    }

    void FixedUpdate()
    {
        Vector2 position = rb2D.position; // assign the position of objects RigidBody2D to position variable

        // moves the RigidBody along the x axis at a speed dependent on the values previously set
        position.x = position.x + Time.deltaTime * speed * direction; 
        rb2D.MovePosition(position);
    }
}
