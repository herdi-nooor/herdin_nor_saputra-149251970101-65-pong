using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour
{

    public Vector2 speed;
    private Rigidbody2D rig;
    public Vector2 resetPosition;
    
    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>(); 
        rig.velocity = speed;
    }

    public void ResetBall() 
    { 
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 0); 
    } 

}
