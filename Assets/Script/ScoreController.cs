using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text LeftScore; 
    public Text RightScore; 
 
    public ScoreManager manager;

    private void Update() 
    { 
        LeftScore.text = manager.leftScore.ToString(); 
        RightScore.text = manager.rightScore.ToString(); 
    } 
}
