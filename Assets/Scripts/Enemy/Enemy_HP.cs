﻿using UnityEngine;

public class Enemy_HP : Enemy
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
