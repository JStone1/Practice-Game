using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        CharacterController controller = other.GetComponent<CharacterController>();
        if(controller != null)
        {
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
