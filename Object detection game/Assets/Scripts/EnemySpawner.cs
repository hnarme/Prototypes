using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    public float respawnTime = 1.0f;
    public float spawnStart;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enemyWave());
    }

    public void spawnEnemy()
    {
        Instantiate(Enemy, new Vector3(Random.Range(-3.6f, 2f), Random.Range(2.3f, 4.5f), spawnStart), transform.rotation);
    }

    IEnumerator enemyWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
