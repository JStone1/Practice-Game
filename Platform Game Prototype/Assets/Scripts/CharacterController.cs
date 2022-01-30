using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    private Rigidbody2D rb2D; // variable that refers to the rigidbody of the character
    public float xSpeed, jumpForce; // variables to store the speed and jump force of character - made public so can adjust in Unity
    public GroundCheck groundcheck; // public variable that references the ground check script

    // variables to store the players current score and the max score they can acheive
    public int maxGroundScore;
    public int maxEnemyScore;
    public int currentGroundScore;
    public int currentEnemyScore;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = this.GetComponent<Rigidbody2D>(); // assigns variable to the RigidBody2D of whatever game object this script is attached to 
        
        // initialise variables at the start of the script
        currentGroundScore = 0;
        currentEnemyScore = 0;
        maxGroundScore = 50;
        maxEnemyScore = 5;
    }

    // Update is called once per frame
    void Update()
    {
        rb2D.velocity = new Vector2(Input.GetAxis("Horizontal") * xSpeed, rb2D.velocity.y); // 

        // checks if user presses space bar and the ground check variable is true
        if(Input.GetKeyDown(KeyCode.Space) && groundcheck.isOnTheGround)
        {
            rb2D.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse); // player jumps if previous conditions are met
        }

        // checks if player goes below a threshold on the y axis (if player falls off map) and triggers the game over function
        if (rb2D.position.y < 0f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }

    }

    // function that updates the player ground score on the UI
    public void ChangeGroundScore(int amount)
    {
        currentGroundScore = Mathf.Clamp(currentGroundScore + amount, 0, maxGroundScore);
        Debug.Log(currentGroundScore + "/" + maxGroundScore);
    }

    // function that updates the player enemy score on the UI
    public void ChangeEnemyScore (int amount)
    {
        currentEnemyScore = Mathf.Clamp(currentEnemyScore + amount, 0, maxEnemyScore);
        Debug.Log(currentEnemyScore + "/" + maxEnemyScore);
    }

}
