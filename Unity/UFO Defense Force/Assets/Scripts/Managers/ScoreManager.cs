using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int Score; //keep score values

    public TextMeshProUGUI scoreText; //keeps UI element

    public void IncreaseScore(int amount) //Raises Score
    {
        Score += amount; 
        UpdateScoreText();
    }

    public void DecreaseScore(int amount) //Lowers score
    {
        Score -= amount; 
        UpdateScoreText();
    }

    public void UpdateScoreText() //updates score UI text
    {
        scoreText.text = "Score: " + Score;
    }
}
