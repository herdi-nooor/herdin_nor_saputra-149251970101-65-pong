using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class padlleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;


    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    private void Update()
    {
        // moveing object  width input
        MoveObject(GetInput());
        Debug.Log("paddle speed: " + speed);
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

    public void ActivatePUSpeedUp(int magnitude) 
    { 
        speed += magnitude; 
    }
}
