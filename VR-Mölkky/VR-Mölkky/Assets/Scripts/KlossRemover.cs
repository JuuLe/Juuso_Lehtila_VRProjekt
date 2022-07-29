using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KlossRemover : MonoBehaviour
{
    public static bool Starting; 

    void Update()
    {
        Debug.Log("StartDetect " + MolkkySpawn.Starting);
       if (MolkkySpawn.Starting == true)
        {
            Destroy(gameObject);
        } 
    }
}
