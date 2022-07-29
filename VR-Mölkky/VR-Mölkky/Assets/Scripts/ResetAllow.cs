using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAllow : MonoBehaviour
{
    public static bool AllowNext;
 //   public static float FurthestPin;
    public bool isMoving;
 //   public static float PinDistance;

    private void Start()
    {
        AllowNext = false;
     //   Debug.Log("AllowNext " + AllowNext);
    }

    private void Update()
    {
     //   Debug.Log("ismoving " + isMoving + " AllowNext " + AllowNext + " KlossZ " + KlossReset.currentZ + "PinDistance" + PinLocDtct.PinDistance);
        if (MolkkyMovDtct.isMoving == false || KlossReset.currentZ > PinLocDtct.PinDistance)
        {
            AllowNext = true;
        }
        else
        {
            AllowNext = false;
        }
     //   Debug.Log("AllowNext " + AllowNext);
    }
}
