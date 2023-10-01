using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highscoretext;

    int score = 0;
    int highscore = 0;

    void Start()
    {
        scoreText.text = score.ToString() + " POINTS";
        highscoretext.text = "HIGHSCORE: " + highscore.ToString();
    }

    void Update()
    {
    
    }
}
