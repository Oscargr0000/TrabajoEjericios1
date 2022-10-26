using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeSphere : MonoBehaviour
{
    public Slider sladerScale;

    public void OnChange()
    {

    float scaldeData = sladerScale.value;
    Vector3 vectorScale = new Vector3(scaldeData, scaldeData, scaldeData);


    transform.localScale = vectorScale;

    }
}
