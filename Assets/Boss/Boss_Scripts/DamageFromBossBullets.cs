using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageFromBossBullets : MonoBehaviour
{
    public bool godMode;
    public float godModeTime;
    float timer = 0;

    private void Start()
    {
        godModeTime = GetComponentInParent<HP_Logic>().flickerT;
        timer = godModeTime;
    }

    void Update()
    {

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            godMode = false;
        }
        else
        {
            godMode = true;
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        if (godMode == false)
        {
            Debug.Log("BossBullets");
            GetComponentInParent<HP_Logic>().TakeDamage(1);
            timer = godModeTime;
        }
    }
}
