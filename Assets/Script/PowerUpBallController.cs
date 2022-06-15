using UnityEngine;

public class PowerUpBallController : MonoBehaviour
{
    public Collider2D ball; 
    public float magnitude; 

    public PowerUpManager manager;
 
    private void OnTriggerEnter2D(Collider2D collision) 
    { 
        if (collision == ball) 
        { 
            ball.GetComponent<ballController>().ActivatePUSpeedUp(magnitude); 
            manager.RemovePowerUp(gameObject); 
        }     
    } 
}