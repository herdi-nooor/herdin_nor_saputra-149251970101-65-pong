using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class padlleController : MonoBehaviour
{
    public int baseSpeed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;

    private float timerSpeed;
    private float powerSpeedInterval;
    private bool powerSpeedUP;
    private int speed;
    // private int baseSize;
    // private int size;

    private ballController ball;

    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        powerSpeedInterval = 5;
        speed = baseSpeed;
        powerSpeedUP = false;
    }

    // Update is called once per frame
    private void Update()
    {
        // moveing object  width input
        MoveObject(GetInput());
        if (powerSpeedUP == true)
        {
            timerSpeed += Time.deltaTime;
    
            if (timerSpeed > powerSpeedInterval) 
            { 
                resetSpeedPadlle();
                powerSpeedUP = false;
                timerSpeed -= powerSpeedInterval; 
            }
        }
    }

    private void resetSpeedPadlle()
    {
        Debug.Log("reset sped");
        speed = baseSpeed;
    }

    private void resetSizePadlle()
    {

    }

    //funtion for get input from player
    private Vector2 GetInput() 
    { 
        if (Input.GetKey(upKey))
        { 
            return Vector2.up * speed; 
        } 
        else if (Input.GetKey(downKey))
        { 
            return Vector2.down * speed; 
        } 
         
        return Vector2.zero; 
    } 
 
    // funtion for moving paddle
    private void MoveObject(Vector2 movement) 
    { 
        rig.velocity = movement; 
    }

    // powerup speed moving padle
    public void ActivatePUSpeedUp() 
    { 
        speed *= 2; 
        powerSpeedUP = true;
    }


    public float TimerSpeed
    {
        get
        {
            return this.timerSpeed;
        }
    }
     public float Speed
    {
        get
        {
            return this.speed;
        }
    }
}
