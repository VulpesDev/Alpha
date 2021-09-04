using System.Collections;
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
    //rotation

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;  // Add to another management script !
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
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
        Debug.Log(mPosX);
        transform.Rotate(new Vector3(0, 0, mPosX));
    }
}
