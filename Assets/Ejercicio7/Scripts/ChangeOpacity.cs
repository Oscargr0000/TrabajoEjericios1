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
        SphereRenderer.material.color = new Vector4(0f, 0f, 0f, 0f);
    }

    
    public void OnChange()
    {

        //When the value of the slider is change, gets the new value and set it in a vector4 (RBGA)
        float sliderValue = sliderController.value;
        SphereRenderer.material.color = new Vector4(0f, 0f, 0f, sliderValue);
    }
}
