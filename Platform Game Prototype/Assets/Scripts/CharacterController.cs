using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    private Rigidbody2D rb2D;
    private BoxCollider2D boxCollider2d;
    public float xSpeed, jumpForce;
    public GroundCheck groundcheck;

    public int maxGroundScore;
    public int maxEnemyScore;
    public int currentGroundScore;
    public int currentEnemyScore;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = this.GetComponent<Rigidbody2D>();
        currentGroundScore = 0;
        currentEnemyScore = 0;
        maxGroundScore = 47;
        maxEnemyScore = 3;
    }

    // Update is called once per frame
    void Update()
    {
        rb2D.velocity = new Vector2(Input.GetAxis("Horizontal") * xSpeed, rb2D.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) && groundcheck.isOnTheGround)
        {
            rb2D.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }

    }

    public void ChangeGroundScore(int amount)
    {
        currentGroundScore = Mathf.Clamp(currentGroundScore + amount, 0, maxGroundScore);
        Debug.Log(currentGroundScore + "/" + maxGroundScore);
    }

    public void ChangeEnemyScore (int amount)
    {
        currentEnemyScore = Mathf.Clamp(currentEnemyScore + amount, 0, maxEnemyScore);
        Debug.Log(currentEnemyScore + "/" + maxEnemyScore);
    }

}
