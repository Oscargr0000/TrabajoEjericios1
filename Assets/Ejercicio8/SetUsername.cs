using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SetUsername : MonoBehaviour
{

    public TMP_InputField inputTextUI;
    public TMP_Text welcomeText;
    public GameObject welcomeTextObj;


    //When you click on the button, gets the input text and check if is empty or not, if is not add the username to a text
    public void OnClick()
    {
        string username = inputTextUI.text;

        if (username == null)
        {
            Debug.Log("No hay Usuario");
        }
        else
        {
            welcomeTextObj.SetActive(true);
            welcomeText.text = "Hello, " + username +" and welcome to this amazing adventure";
        }

    }
}
