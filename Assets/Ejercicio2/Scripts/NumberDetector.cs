using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumberDetector : MonoBehaviour
{
    public TMP_InputField inputNumber;
    public TextMeshProUGUI textOutput;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int NumberDetected = int.Parse(inputNumber.text);

            if(NumberDetected % 2 == 0)
            {
                textOutput.text = "Even";
            }
            else
            {
                textOutput.text = "Odd";
            }
        }
    }
}
