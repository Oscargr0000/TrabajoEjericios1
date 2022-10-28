using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInPosition : MonoBehaviour
{
    public Vector3[] positions;
    public GameObject capsule;

    void Update()
    {

        //When the S key is press, calls a "for" that instantiate the spheres the same number of time as the legth of th array.
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
