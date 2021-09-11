using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_HP : MonoBehaviour
{
    public int hp = 100;
    public void TakeDamage(int amount)
    {
        hp -= amount;
    }
    public void Die()
    {
        Destroy(gameObject);
        //Special effects and sounds
    }
}