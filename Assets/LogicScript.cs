using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int scorePoints;
    public Text scoreText;
    public GameObject gameOver;

    public void addScore(int scoreToAdd)
    {
        scorePoints = scorePoints + scoreToAdd;
        scoreText.text = scorePoints.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void gameOv(){
        gameOver.SetActive(true);
        
    }
}
