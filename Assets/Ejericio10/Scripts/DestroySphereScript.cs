using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestroySphereScript : MonoBehaviour
{
    private GameManager GM;
    public TMP_Text contadorText;

    private void Start()
    {
        GM = FindObjectOfType<GameManager>();
    }


    // When the sphere is press desactivate the gameobject and add a point to the counter hosted in the Game Manager
    private void OnMouseDown()
    {
        if (gameObject.CompareTag("Sphere"))
        {
            GM.contadorSphere++;
            gameObject.SetActive(false);

            contadorText.text = GM.contadorSphere.ToString();
        }
    }
}
