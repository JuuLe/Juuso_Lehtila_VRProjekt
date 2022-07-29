using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MolkkySpawn : MonoBehaviour
{
    public static bool Starting;
    public GameObject Molkky;

   public void Spawn()
    {

        Instantiate(Molkky, transform.position, transform.rotation);
        Starting = false;
        Debug.Log("Starting " + Starting);
    }
}
