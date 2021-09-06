using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attacks : MonoBehaviour
{
    [SerializeField] Transform lSpawnPoint, rSpawnPoint;
    GameObject projectilePref;
    bool cooldown = false;
    float cooldownValue = 2f;

    void Start()
    {
        projectilePref = Resources.Load<GameObject>("Projectile");
    }

    void Update()
    {
        if(Input.GetAxis("Fire1") > 0 && !cooldown)
        {
            Instantiate(projectilePref, lSpawnPoint.position, lSpawnPoint.rotation);
            StartCoroutine(StartTimer(cooldownValue));
        }
        else if (Input.GetAxis("Fire2") > 0 && !cooldown)
        {
            Instantiate(projectilePref, rSpawnPoint.position, rSpawnPoint.rotation);
            StartCoroutine(StartTimer(cooldownValue));
        }
    }
    IEnumerator StartTimer(float time)
    {
        cooldown = true;
        yield return new WaitForSeconds(time);
        cooldown = false;
    }
}
