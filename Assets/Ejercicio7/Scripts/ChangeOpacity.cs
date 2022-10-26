using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeOpacity : MonoBehaviour
{
    public Slider sliderController;
    private Renderer SphereRenderer;


    void Start()
    {
        SphereRenderer = GetComponent<Renderer>();
    }

    
    public void OnChange()
    {
      //  SphereRenderer.material.
    }
}
