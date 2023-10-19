using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    public string NameCollectable;
    public int score;

    public int restoreHP;

    public Collectables(string name, int scoreValue)
    {
        this.NameCollectable = name;
        this.score = scoreValue;
    }
    public void UpdateScore()
    {
        ScoreManager.scoreManager.UpdateScore(score);
    }


}


