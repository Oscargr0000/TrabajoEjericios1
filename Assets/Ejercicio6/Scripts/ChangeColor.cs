using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeColor : MonoBehaviour
{
    private Renderer colorCubo;
    public TMP_Dropdown lista;


    void Start()
    {
        colorCubo = GetComponent<Renderer>();
    }


    public void SelectColor()
    {
        if( lista.value == 0)
        {
            colorCubo.material.SetColor("_Color", Color.red);
        }else if(lista.value == 1)
        {
            colorCubo.material.SetColor("_Color", Color.blue);
        }else if(lista.value == 2)
        {
            colorCubo.material.SetColor("_Color", Color.green);
        }else if(lista.value == 3)
        {
            colorCubo.material.SetColor("_Color", Color.black);
        }else if(lista.value == 4)
        {
            colorCubo.material.SetColor("_Color", Color.cyan);
        }
    }
}
