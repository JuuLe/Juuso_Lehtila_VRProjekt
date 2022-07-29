using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
   [HideInInspector] public static int score;
   public static int FallScore;
   public static int ValueScore;

    public GameObject Pin;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Mölkky"))
        {
            FallScore++;
            ValueScore = other.GetComponent<PinValue>().PinNumber;
        }

        {
            if (FallScore == 1)
            {
                score = ValueScore;
            }
            else
            {
                score = FallScore;
            }

        }
    //    Debug.Log("Fall" + FallScore);
    //    Debug.Log("Value" + ValueScore);
    //    Debug.Log("Score" + score);
    }
}
