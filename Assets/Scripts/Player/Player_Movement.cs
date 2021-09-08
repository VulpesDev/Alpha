using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : Player
{
    //movement
    [SerializeField]int speed;
    public bool inverted = true;
    //movement

    //rotation
    float mPosX;
    public float sensitivity = 1;
    //rotation

    void FixedUpdate()
    {
        Rotation();
        Movement();
    }
    void Movement()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(horizontal * speed, vertical * speed);
    }
    void Rotation()

    {
        mPosX = Input.GetAxis("Mouse X");
        //transform.Rotate(new Vector3(0, 0, -mPosX));       //rotate through transform component
        rb.MoveRotation(rb.rotation + (10*sensitivity*mPosX) * (inverted == true ? -1 : 1));  //rotate through rigidbody component
    }
}
