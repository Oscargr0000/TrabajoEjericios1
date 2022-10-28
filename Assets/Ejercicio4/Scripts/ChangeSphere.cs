using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeSphere : MonoBehaviour
{
    public Slider sladerScale;

    // Every time the value of the slider is change, it gets the changed value and set it on a vector3 (XYZ) that will be set as the scale of the object
    public void OnChange()
    {

    float scaldeData = sladerScale.value;
    Vector3 vectorScale = new Vector3(scaldeData, scaldeData, scaldeData);


    transform.localScale = vectorScale;

    }
}
