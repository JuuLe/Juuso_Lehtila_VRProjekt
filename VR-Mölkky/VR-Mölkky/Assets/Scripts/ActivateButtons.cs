using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateButtons : MonoBehaviour
{
   [SerializeField] GameObject RestartBtn;
   [SerializeField] GameObject QuitBtn;

    public void ActivateBtn()
    {
        RestartBtn.SetActive(true);
        QuitBtn.SetActive(true); 
    }
}
