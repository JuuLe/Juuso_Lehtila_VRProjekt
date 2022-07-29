using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KlossSpawner : MonoBehaviour
{
 //   public static bool Starting;
    public GameObject KastKloss;

   public void KlossSpawn()
    {
       // if (Starting == true)
      //  {
      Instantiate(KastKloss, transform.position, transform.rotation);
       // }
    }
}
