using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeakPoint : MonoBehaviour
{
    public PlayerController player;

    public bool isEnemyInjured = false;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isEnemyInjured = true;
            Vector3 hitDirection = collision.transform.position - transform.position;
            hitDirection = hitDirection.normalized;

            player.KnockBack(hitDirection);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isEnemyInjured  = false;
    }
}
