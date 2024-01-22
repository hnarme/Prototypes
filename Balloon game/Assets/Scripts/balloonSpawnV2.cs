using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonSpawnV2 : MonoBehaviour
{
    public GameObject balloonPrefab;
    public float respawnTime = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(balloonWave());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnBalloon()
    {
        GameObject a = Instantiate(balloonPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-6, 6), -22);
    }

    IEnumerator balloonWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnBalloon();
        }
    }
}
