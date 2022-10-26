using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    void Update()
    {
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
