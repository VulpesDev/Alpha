using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attacks : MonoBehaviour
{
    [SerializeField] GameObject lSpawnPoint, rSpawnPoint;
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
            GameObject _pref = Instantiate(projectilePref, lSpawnPoint.transform.position, lSpawnPoint.transform.rotation);
            _pref.GetComponent<Bullet>().GetBulletPoint(lSpawnPoint);
            StartCoroutine(StartTimer(cooldownValue));
        }
        else if (Input.GetAxis("Fire2") > 0 && !cooldown)
        {
            GameObject _pref = Instantiate(projectilePref, rSpawnPoint.transform.position, rSpawnPoint.transform.rotation);
            _pref.GetComponent<Bullet>().GetBulletPoint(rSpawnPoint);
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
