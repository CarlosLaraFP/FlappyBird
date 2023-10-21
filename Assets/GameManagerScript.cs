using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;

    private void Start()
    {
        scoreText.text = playerScore.ToString();
    }

    [ContextMenu("Increase Score")]
    public void IncreaseScore(int points)
    {
        playerScore += points;
        scoreText.text = playerScore.ToString();
    }
}
