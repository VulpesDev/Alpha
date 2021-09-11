using UnityEngine;

public class Player : MonoBehaviour
{
    protected Rigidbody2D rb;

    Player_HP php;
    Player_Movement pmv;
    Player_Attacks pat;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        php = gameObject.GetComponent<Player_HP>();
        pmv = gameObject.GetComponent<Player_Movement>();
        pat = gameObject.GetComponent<Player_Attacks>();
    }
}
