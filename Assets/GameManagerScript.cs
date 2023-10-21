using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;

    [ContextMenu("Increase Score")]
    public void IncreaseScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }
}
