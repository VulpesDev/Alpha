using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected Rigidbody2D rb;
    protected GameObject player;

    Enemy_HP ehp;
    Enemy_Movement emv;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");

        ehp = gameObject.GetComponent<Enemy_HP>();
        emv = gameObject.GetComponent<Enemy_Movement>();
    }
    private void Update()
    {
        if(ehp.hp <= 0)
        {
            ehp.Die();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Projectile"))
        {
            ehp.TakeDamage(100);
        }
    }
}
