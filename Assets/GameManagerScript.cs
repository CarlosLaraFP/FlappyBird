using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public int playerScore = 0;
    // Caution: If you make this private after the drag-and-drop link is established, the link disappears.
    public Text scoreText;
    public GameObject gameOverScreen;

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

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
