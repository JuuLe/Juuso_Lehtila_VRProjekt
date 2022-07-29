using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineLoc : MonoBehaviour
{
    public static float Location;

    void Start()
    {
        Location = transform.position.z;
    }
}
