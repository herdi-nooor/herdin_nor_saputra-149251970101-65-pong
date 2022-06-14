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

    // method untuk menambah nilai pemain sebelah kanan
    public void AddRightScore(int increment) 
    { 
        rightScore += increment; 
        ball.ResetBall(); 
 
        if (rightScore >= maxScore) 
        { 
            GameOver(); 
        } 
    } 
 
    // method untuk menambah nilai pemain sebelah kiri
    public void AddLeftScore(int increment) 
    { 
        leftScore += increment; 
        ball.ResetBall(); 
 
        if (leftScore >= maxScore) 
        { 
            GameOver(); 
        } 
    } 
 
    // method jika permainan selesao dan mengembalikan ke scene "Main menu"
    public void GameOver() 
    { 
        SceneManager.LoadScene("Main Menu");
    }

}
