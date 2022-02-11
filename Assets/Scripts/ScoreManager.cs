using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class  ScoreManager : MonoBehaviour
{
    public int score;
    public GameObject scoreText;

    public void Start()
    {
        score = 0;
    }
    public void PlusScore()
    {
        score++;
        scoreText.GetComponent<TextMesh>().text = "Score : " + score;
    }
}
