using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveEnemiesData
{
    public float[] enemyposition;
    public int health;

    public SaveEnemiesData (EnemyController enemyController, EnemyHealthManager enemyHealthManager)
    {
        health = enemyHealthManager.currentHealth;

        enemyposition = new float[3];
        enemyposition[0] = enemyController.transform.position.x;
        enemyposition[1] = enemyController.transform.position.y;
        enemyposition[2] = enemyController.transform.position.z;
    }
}
