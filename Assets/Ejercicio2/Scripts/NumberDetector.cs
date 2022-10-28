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
        //When the space bar is press, get the number from the input and divided by 2, if the rest is 0 the number is Even, if not the number must be Odd
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
