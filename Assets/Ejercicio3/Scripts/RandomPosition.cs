using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    void Update()
    {
        // When the E is pressed, generate a random number for every position (X,Y,Z) and set it in the vector that will be set as the position of the object.
        if (Input.GetKeyDown(KeyCode.E))
        {
            float randomX = Random.Range(-9f, 9f);
            float randomY = Random.Range(-5f, 5f);
            float randomZ = Random.Range(2f, 20f);

            Vector3 RandomPosition = new Vector3(randomX, randomY, randomZ);

            transform.position = RandomPosition;
        }
    }
}
