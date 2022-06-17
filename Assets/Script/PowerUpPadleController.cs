using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpPadleController : MonoBehaviour
{
    public Collider2D ball; 
    public PowerUpManager manager;
    private GameObject player;

    // mengambil nama padle yang tersimpan di ballControler, yang terakhir tertabrak oleh ball
    private string namaPaddle()
    {
        string nama = ball.GetComponent<ballController>().paddle;
        return nama ;
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    { 
        
        player = GameObject.Find(namaPaddle());
        if (collision == ball) 
        { 
            player.GetComponent<padlleController>().ActivatePUSpeedUp(); 
            manager.RemovePowerUp(gameObject); 
        }     
    } 
}
