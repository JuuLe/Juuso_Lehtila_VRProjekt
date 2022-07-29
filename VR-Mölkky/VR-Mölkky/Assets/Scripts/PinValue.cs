using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinValue : MonoBehaviour
{
    public int PinNumber = 0;
    public Text DisplayedNumber;

    private void Update()
    {
        DisplayedNumber.text = PinNumber.ToString();
    }

}
