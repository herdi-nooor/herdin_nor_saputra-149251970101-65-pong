using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpPadleController : MonoBehaviour
{
    public Collider2D ball; 
    private GameObject player;
    public int magnitude; 

    public PowerUpManager manager;
 
    private void OnTriggerEnter2D(Collider2D collision) 
    { 
        player = GameObject.Find("padlle2");
        if (collision == ball) 
        { 
            player.GetComponent<padlleController>().ActivatePUSpeedUp(magnitude); 
            manager.RemovePowerUp(gameObject); 
        }     
    } 
}
