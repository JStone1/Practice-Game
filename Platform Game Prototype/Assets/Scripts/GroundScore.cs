using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScore : MonoBehaviour
{

    public AudioSource sound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        CharacterController controller = other.GetComponent<CharacterController>();
        if(controller != null)
        {
            sound.Play();
            controller.ChangeGroundScore(1);
            Destroy(gameObject);
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
