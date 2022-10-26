using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GenerateNum : MonoBehaviour
{
    private int randomNum;
    public TextMeshProUGUI textNum;

    public void OnClick()
    {
        randomNum = Random.Range(0, 1000);
        string textInput = randomNum.ToString();
        textNum.text = textInput;
    }
}
