using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -40.0f;
    private float bottomLimit = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (gameObject.name == "Dog(Clone)" && transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (gameObject.name != "Dog(Clone)" && transform.position.z < bottomLimit)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        }

    }
}
