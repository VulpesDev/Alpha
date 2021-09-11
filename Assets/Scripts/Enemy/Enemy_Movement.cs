using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : Enemy
{
    [SerializeField] float speed = 1f;
    bool followPlayer = true;
    [SerializeField]float followDistance = 4f;


    private void FixedUpdate()
    {
            //Distance Debug\\
        //Debug.Log(Vector2.Distance(player.transform.position, transform.position).ToString("F2"));
        if(Vector2.Distance(player.transform.position, transform.position) < followDistance)
        {
            followPlayer = false;
        }
        else
        {
            followPlayer = true;
        }

        if (followPlayer)
        {
            rb.velocity = (player.transform.position - transform.position).normalized * speed * Time.deltaTime * 100f;
        }
    }
}
