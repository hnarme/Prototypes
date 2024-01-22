using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    public int level;
    public float[] playerPosition;
    public int playerHealth;
    public float[] enemyPosition;
    public int enemyHealth;

    public SaveData(LevelIdentifier levelIdentifier ,PlayerController playerController, HealthManager healthManager, EnemyController enemyController, EnemyHealthManager enemyHealthManager)
    {
        level = levelIdentifier.level;

        playerHealth = healthManager.currentHealth;

        playerPosition = new float[3];
        playerPosition[0] = playerController.transform.position.x;
        playerPosition[1] = playerController.transform.position.y;
        playerPosition[2] = playerController.transform.position.z;

        enemyHealth = enemyHealthManager.currentHealth;

        enemyPosition = new float[3];
        enemyPosition[0] = enemyController.transform.position.x;
        enemyPosition[1] = enemyController.transform.position.y;
        enemyPosition[2] = enemyController.transform.position.z;
    }
}
