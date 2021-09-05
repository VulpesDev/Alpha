﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //movement
    Rigidbody2D rb;
    [SerializeField]int speed;
    //movement

    //rotation
    float mPosX;
    float sensitivity;
    //rotation

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;  // Add to another management script !
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

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
        rb.MoveRotation(rb.rotation + (sensitivity*mPosX));  //rotate through rigidbody component
    }
}
