using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuController : MonoBehaviour
{
    // method untuk menjalankan scene "Credit"
    public void OpenAuthor() 
    { 
        SceneManager.LoadScene("Credit");
    }
    
    // method untuk menjalankan scene "Game"
    public void PlayGame() 
    { 
        SceneManager.LoadScene("Game"); 
        Debug.Log("Created By Herdin nor saputra - 149251970101-65");
    } 

} 

