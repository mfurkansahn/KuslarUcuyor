using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    [SerializeField]
    int playerScore = 0;

    [SerializeField]
    Text playerScoreText;

    [SerializeField]
    GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore (int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        playerScoreText.text = "Score : " + playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
