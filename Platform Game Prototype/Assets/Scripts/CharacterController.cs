using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    private Rigidbody2D rb2D;
    public float xSpeed, jumpForce;
    public GroundCheck groundcheck;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2D.velocity = new Vector2(Input.GetAxis("Horizontal") * xSpeed, rb2D.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && groundcheck.isOnTheGround)
        {
            rb2D.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
}