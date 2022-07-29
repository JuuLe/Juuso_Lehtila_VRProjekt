using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinLocDtct : MonoBehaviour
{
    public static float PinDistance;

    void Update()
    {
        if (transform.position.z > PinDistance)
        {
            PinDistance = transform.position.z;
            
        }
    }
}
