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
        padle1.text = padlle1.speed.ToString();
        padle2.text = padlle2.speed.ToString();
    } 


}
