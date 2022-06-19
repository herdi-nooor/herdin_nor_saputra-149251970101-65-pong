using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour
{

    public Vector2 speed;
    private Rigidbody2D rig;
    private string Paddle;

    
    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }
    public string paddle
    {
        get
        {
            return this.Paddle;
        }
    }

    // method untuk mereset posisi bola
    public void ResetBall() 
    { 
        if(paddle == "padlle2")
        {
            transform.position = new Vector3(8,0, 0);
            rig.velocity = -speed;
        }else if(paddle == "padlle1"){
            transform.position = new Vector3(-8, 0, 0);
            rig.velocity = speed;
        }
    } 

    // method jika bola mengenai powerUp
    public void ActivatePUSpeedUp(float magnitude) 
    { 
        rig.velocity *= magnitude; 
    }

    // mengecek paddle mana yang terakhir di tabrak oleh bola
    private void OnCollisionEnter2D (Collision2D collisionInfo) 
    {
        string lastCollision = collisionInfo.collider.tag;
        string name = collisionInfo.collider.name;
        if ( lastCollision == "Player")
        {
            Paddle = name;
        }
    }
}
