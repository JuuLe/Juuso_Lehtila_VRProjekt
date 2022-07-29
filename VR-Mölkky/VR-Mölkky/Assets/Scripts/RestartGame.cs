using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartGame : MonoBehaviour
{
    public static bool Starting;
    public static bool win;
    // [SerializeField] GameObject RestartBtn;
    // [SerializeField] GameObject QuitBtn;

    public void Restart ()
    {
        Starting = true;
        NextThrowScore.TotalScore = 0;
        NextThrowScore.Throws = 0;
        NextThrowScore.win = false;
        GameObject[] Molkyt = GameObject.FindGameObjectsWithTag("Mölkky");
        foreach (GameObject Mölkky in Molkyt)
        {
            Destroy(Mölkky);
        }
        GameObject[] Klossar = GameObject.FindGameObjectsWithTag("KastKloss");
        foreach (GameObject KastKloss in Klossar)
        {
            Destroy(KastKloss);
        }
        //   RestartBtn.SetActive(false);
        //   QuitBtn.SetActive(false);
    }
}
