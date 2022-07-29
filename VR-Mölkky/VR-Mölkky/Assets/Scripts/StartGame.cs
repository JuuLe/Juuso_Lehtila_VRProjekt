using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
 //   public static bool Starting = false;
    [SerializeField] GameObject menu;

    public void Begin()
    {
 //       Starting = true;
 //       Debug.Log("Starting " + Starting);
        menu.SetActive(false);
    }
}
