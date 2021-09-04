using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //movement
    Rigidbody2D rb;
    [SerializeField]int speed;
    //movement
    float mPosX;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        mPosX = Input.GetAxis("Mouse X");
        Debug.Log(mPosX);
        transform.Rotate(new Vector3(0, 0, mPosX));
        Movement();
    }
    void Movement()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(horizontal * speed, vertical * speed);
    }
}
