using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowRules : MonoBehaviour
{
    [SerializeField] GameObject Title;
    [SerializeField] GameObject Instructions;
    [SerializeField] GameObject StartBtn;

    public void Rules ()
    {
        Title.SetActive(false);
        Instructions.SetActive(true);
        StartBtn.SetActive(true);
    }
}
