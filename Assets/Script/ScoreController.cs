using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text LeftScore; 
    public Text RightScore;
    public ScoreManager manager;

    // haua untuk mengecek, akan dihapus
    public Text padle1;
    public Text padle2;
    public padlleController padlle1;
    public padlleController padlle2;
 


    private void Update() 
    { 
        LeftScore.text = manager.leftScore.ToString(); 
        RightScore.text = manager.rightScore.ToString();
        padle1.text = "player 1 : " + padlle1.Speed.ToString() + "\n speed up : " + ((int)padlle1.TimerSpeed).ToString();
        padle2.text = "player 1 : " + padlle2.Speed.ToString() + "\n speed up : " + ((int)padlle2.TimerSpeed).ToString();
    } 


}
