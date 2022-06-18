using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text LeftScore; 
    public Text RightScore;
    public ScoreManager manager;

    public paddleController padlle1;
    public paddleController padlle2;
 


    private void Update() 
    { 
        LeftScore.text = manager.leftScore.ToString(); 
        RightScore.text = manager.rightScore.ToString();
        Debug.Log("paddle speed player 1 : " + padlle1.Speed.ToString() +
                    "\npaddle speed player 2 : " + padlle2.Speed.ToString());
    } 


}
