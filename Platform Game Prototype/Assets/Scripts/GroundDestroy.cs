using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

public class GroundDestroy : MonoBehaviour
{
    public Tile tile;
    public Score score;
    public AudioSource sound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9 || collision.gameObject.layer == 11)
        {
            print("Collision enter");
            sound.Play();
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            print("Trigger enter");
            Destroy(collision.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

}
