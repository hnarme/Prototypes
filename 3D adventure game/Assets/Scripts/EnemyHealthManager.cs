using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public bool isDead = false;

    public HealthBarEnemy healthBarEnemy;

    public EnemyWeakPoint enemyWeakPoint;

    // Start is called before the first frame update
    void Start()
    {
        healthBarEnemy = GetComponent<HealthBarEnemy>();

        enemyWeakPoint = GetComponentInChildren<EnemyWeakPoint>();

        currentHealth = maxHealth;

        healthBarEnemy.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth == 0)
        {
            isDead = true;
            gameObject.SetActive(false);
        }

        if (enemyWeakPoint.isEnemyInjured)
        {
            TakeDamage();
        }

        healthBarEnemy.SetHealth(currentHealth);
    }

    public void TakeDamage()
    {
        currentHealth--;
    }
}
