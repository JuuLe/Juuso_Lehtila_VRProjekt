using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    public static int fullScore;
    public static int throws;
    string ScoreText;
    string TriesText;
    public Text playerscore;
    public static bool win;
    public PrimaryButtonWatcher watcher;
    public bool IsPressed;

    private void Start()
    {
        playerscore = GameObject.Find("ScoreText").GetComponent<Text>();
        ScoreText = fullScore.ToString();
        TriesText = throws.ToString();
        playerscore.text = "Poäng " + ScoreText + " Kast " + TriesText;
        Debug.Log("Poäng " + fullScore + "Kast " + throws);
    }

    private void Update()
        //onPrimaryButtonEvent(bool pressed)
    {
 //       if (IsPressed = pressed)
 //       {
            fullScore = NextThrowScore.TotalScore;
            throws = NextThrowScore.Throws;
            win = NextThrowScore.win;
            ScoreText = fullScore.ToString();
            TriesText = throws.ToString();
       //     Debug.Log ("Poäng " + fullScore + "Kast " + throws);

            if (win == true)
            {
                playerscore.text = "Du vann med " + TriesText + " kast!";
            }
            else
            {
                playerscore.text = "Poäng " + ScoreText + " Kast " + TriesText;
            }
//        }
    }
}
