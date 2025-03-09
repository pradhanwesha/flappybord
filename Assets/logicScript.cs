using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverscreen;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore += 1;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private bool isGameOver = false; // Now used correctly

    public void gameOver()
    {
        if (isGameOver) return; // Prevent multiple calls
        isGameOver = true; // Mark game as over

        Debug.Log("Game Over function called!"); // Debugging
        gameOverscreen.SetActive(true);
    }


    void Start()
    {
        gameOverscreen.SetActive(false); // Make sure it's hidden at the start
    }

}