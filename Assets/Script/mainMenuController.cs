using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuController : MonoBehaviour
{
    public void OpenAuthor() 
    { 
        Debug.Log("Created By Gue"); 
    }
    
    public void PlayGame() 
    { 
        SceneManager.LoadScene("Game"); 
    } 

} 

