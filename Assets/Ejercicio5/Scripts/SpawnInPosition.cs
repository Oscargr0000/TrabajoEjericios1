using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInPosition : MonoBehaviour
{
    public Vector3[] positions;
    public GameObject capsule;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int forLimit = positions.Length;
            for(int i = 0; i < forLimit; i++)
            {
                Instantiate(capsule, positions[i],transform.rotation);
            }   
        }
    }
}
