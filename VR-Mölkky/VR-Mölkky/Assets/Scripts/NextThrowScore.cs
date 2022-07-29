using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using CommonUsages = UnityEngine.XR.CommonUsages;
using InputDevice = UnityEngine.XR.InputDevice;

public class NextThrowScore : MonoBehaviour
{
    public Score score;
    public PrimaryButtonWatcher watcher;
    public bool IsPressed = false; // used to display button state in the Unity Inspector window
    // public static int score;
    public static int TotalScore;
    public static int Throws;
    bool isMoving;
    public static bool win = false;
    public static bool menu;
    [SerializeField] GameObject RestartBtn;
    [SerializeField] GameObject QuitBtn;
    public static bool AllowNext;

    void Start()
    {
        watcher.primaryButtonPress.AddListener(onPrimaryButtonEvent);
        TotalScore = 0;
        Throws = 0;

    }

    //private IEnumerator MoveCheck()
    //{

 //       MolkkyMovDtct.isMoving = false;

//        Debug.Log("timer start" + isMoving);
    //    yield return new WaitForSeconds(0.5F);

     //   isMoving = MolkkyMovDtct.isMoving;

 //       Debug.Log("timer over" + isMoving);


    //}

    public void onPrimaryButtonEvent(bool pressed)
    {
        if (IsPressed = pressed)
        {          
            Debug.Log("Score AllowReset" + ResetAllow.AllowNext);
            if (ResetAllow.AllowNext == true && KlossReset.currentZ > LineLoc.Location)
            {
                // Debug.Log("moveCheck active");


                Throws++;
                TotalScore = TotalScore + Score.score;


                if (TotalScore == 50)
                {
                    win = true;
                    menu = true;
                    //RestartBtn.SetActive(true);
                    //QuitBtn.SetActive(true);
                }

                if (TotalScore > 50)
                {
                    TotalScore = 25;
                }

                //  Debug.Log("Throws " + Throws);
                //   Debug.Log("Total Score " + TotalScore);
                Score.score = 0;
                Score.ValueScore = 0;
                Score.FallScore = 0;
            }
        }
    }
}
