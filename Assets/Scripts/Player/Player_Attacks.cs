using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attacks : MonoBehaviour
{
    [SerializeField] GameObject lSpawnPoint, rSpawnPoint;
    GameObject projectilePref;
    bool cooldownL = false, cooldownR = false;
    float cooldownValue = 2f;

    void Start()
    {
        projectilePref = Resources.Load<GameObject>("Projectile");
    }

    void Update()
    {
        if(Input.GetAxis("Fire1") > 0 && !cooldownL)
        {
            GameObject _pref = Instantiate(projectilePref, lSpawnPoint.transform.position, lSpawnPoint.transform.rotation);
            _pref.GetComponent<Bullet>().GetBulletPoint(lSpawnPoint);
            StartCoroutine(StartTimerL(cooldownValue));
        }
        else if (Input.GetAxis("Fire2") > 0 && !cooldownR)
        {
            GameObject _pref = Instantiate(projectilePref, rSpawnPoint.transform.position, rSpawnPoint.transform.rotation);
            _pref.GetComponent<Bullet>().GetBulletPoint(rSpawnPoint);
            StartCoroutine(StartTimerR(cooldownValue));
        }
    }
    IEnumerator StartTimerL(float time)
    {
        cooldownL = true;
        yield return new WaitForSeconds(time);
        cooldownL = false;
    }
    IEnumerator StartTimerR(float time)
    {
        cooldownR = true;
        yield return new WaitForSeconds(time);
        cooldownR = false;
    }

}
