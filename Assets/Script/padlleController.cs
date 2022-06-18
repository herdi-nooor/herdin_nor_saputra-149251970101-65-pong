using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class padlleController : MonoBehaviour
{
    public int baseSpeed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;
    private float powerInterval;

    private float timerSpeed;
    private bool powerSpeedUP;
    private int speed;

    private float timerSize;
    private bool powerSizeUP;
    private Vector2 size;

    private ballController ball;

    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        powerInterval = 5;
        speed = baseSpeed;
        powerSpeedUP = false;
        powerSizeUP = false;
    }

    // Update is called once per frame
    private void Update()
    {
        // moveing object  width input
        MoveObject(GetInput());

        // check is power up speed active
        if (powerSpeedUP == true)
        {
            timerSpeed += Time.deltaTime;
    
            if (timerSpeed > powerInterval) 
            { 
                resetSpeedPadlle();
                powerSpeedUP = false;
                timerSpeed -= powerInterval; 
            }
        }

        // check is pewer up size active
        if (powerSizeUP == true)
        {
            timerSize += Time.deltaTime;
    
            if (timerSize > powerInterval) 
            { 
                resetSizePadlle();
                powerSizeUP = false;
                timerSize -= powerInterval; 
            }
        }
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

    // for reset value
    private void resetSpeedPadlle()
    {
        speed = baseSpeed;
    }
    private void resetSizePadlle()
    {
        transform.localScale = new Vector2((float)0.5 , 4);
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
    // powerup size scale of padle
    public void ActivatePUSizeUp()
    {
        transform.localScale = new Vector2(1, 8);
        powerSizeUP = true;
    }





// akan di hapus code dibawah
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
    public float TimerSize
    {
        get
        {
            return this.timerSize;
        }
    }
}
