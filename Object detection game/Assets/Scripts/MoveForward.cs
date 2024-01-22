using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public PlayerHealthManager playerHealthManager;
    public float speed = 0.1f;
    public float x = 3.4f;
    public float y = 1.4f;
    public float z = 0f;
    public Vector3 respawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.1f;
        z = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        z = z + speed;

        gameObject.transform.localPosition = new Vector3(x, y, z);

        if (playerHealthManager.isRespawning)
        {
            respawnPosition = playerHealthManager.respawnPoint;
            z = 0f;
        }

    }
}
