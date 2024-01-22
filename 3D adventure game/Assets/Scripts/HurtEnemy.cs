using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour
{
    public EnemyHealthManager healthManager;

    public PlayerController player;


    // Start is called before the first frame update
    void Start()
    {
        healthManager = FindObjectOfType<EnemyHealthManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DamageEnemy")
        {
            Debug.Log("Enemy took damage!");
            healthManager.TakeDamage();

            Vector3 hitDirection = other.transform.position - transform.position;
            hitDirection = hitDirection.normalized;

            player.KnockBack(hitDirection);
        }
    }
}
