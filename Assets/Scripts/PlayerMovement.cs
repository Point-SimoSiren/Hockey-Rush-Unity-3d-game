using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardSpeed = 400f;
    public float sidewaysForce = 700f;
    //public float jumpForce = 30f;

    // Update is called once per frame
    void FixedUpdate()
    {
            rb.AddForce(0, 0, forwardSpeed * Time.deltaTime, ForceMode.VelocityChange);
     
            if (Input.GetKey("right"))
                {
                   rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange) ;
                }
           
            if (Input.GetKey("left"))
                {
                    rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }
           

            if (rb.position.y < -3f)
             {
                FindObjectOfType<GameManager>().EndGame();
             }

    }
 }

