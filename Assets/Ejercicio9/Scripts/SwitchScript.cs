using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchScript : MonoBehaviour
{
    public Light bombilla;
    public Toggle switchLight;

    public void OnChange()
    {
        if (switchLight.isOn == true)
        {
            bombilla.intensity = 5f;
        }
        else
        {
            bombilla.intensity = 0f;
        }
    }
}
