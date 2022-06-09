using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int rightScore; 
    public int leftScore;
    public int maxScore;
    public ballController ball;

    public void AddRightScore(int increment) 
    { 
        rightScore += increment; 
        ball.ResetBall(); 
 
        if (rightScore >= maxScore) 
        { 
            GameOver(); 
        } 
    } 
 
    public void AddLeftScore(int increment) 
    { 
        leftScore += increment; 
        ball.ResetBall(); 
 
        if (leftScore >= maxScore) 
        { 
            GameOver(); 
        } 
    } 
 
    public void GameOver() 
    { 
        SceneManager.LoadScene("Main Menu");
    }

}
