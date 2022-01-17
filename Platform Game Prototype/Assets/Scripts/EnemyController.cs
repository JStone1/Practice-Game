using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public bool horizontal;
    public float speed;
    public float changeTime = 1.0f;

    Rigidbody2D rb2D;
    float timer;
    int direction = 1;

    
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        timer = changeTime;
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        }
    }

    void FixedUpdate()
    {
        Vector2 position = rb2D.position;

        if(horizontal)
        {
            position.x = position.x + Time.deltaTime * speed * direction;
        }
        else
        {
            position.y = position.y + Time.deltaTime * speed * direction;
        }

        rb2D.MovePosition(position);
    }
}
