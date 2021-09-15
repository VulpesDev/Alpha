using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = 0f, lowSpeed = 3f;
                                     /// speed - current speed ; lowSpeed - lowest speed limit (if speed lower lowSpeed)
                                     /// then destroy the object

  
    bool locked = true, checkSpeed = false;

    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    Transform spPos;                  // spawn position that the bullet follows until unlocked
    public void GetBulletPoint(GameObject spawnpoint)  // set the spawn point
    {
        spPos = spawnpoint.transform;
    }


    void Update()
    {
        // Speed Check
        SpeedCheck();
        // \\Speed Check

        // Lock Check
        if (locked)
        {
            rb.MovePosition(spPos.position);
        }
        // \\Lock Check

    }
    void SpeedCheck()
    {
        speed = rb.velocity.magnitude;
        if (!locked)
        {
            if (!checkSpeed)
                Invoke("CheckSpeed", 0.2f);
            else
            if (speed < lowSpeed)
            {
                Destroy();
            }
        }
    }
    void CheckSpeed()
    {
        checkSpeed = true;
    }

    //Collisions
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(!collision.collider.CompareTag("Player"))  // if not player - destroy
        {
            Destroy();
        }
        else
        {
            locked = false;                        // if player then unlock
        }
    }
    // \\Collisions

    void Destroy()
    {
        Instantiate(Resources.Load<GameObject>("Explotion"), transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
