using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    public int damageToGive = 1;

    public HealthManager healthManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "DamagePlayer")
        {
            healthManager.currentHealth--;

            healthManager.HurtPlayer(damageToGive);
        }
    }

    public int DamagePlayer()
    {
        return damageToGive;
    }
}