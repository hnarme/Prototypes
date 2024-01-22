using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5.0F;
    private Vector3
    moveDirection = Vector3.zero;

    void Start()
    {

    }
    void Update()
    {
        CharacterController player = GetComponent<CharacterController>();
        // constantly move forward
        moveDirection.z = -speed;
        // finally, we actually apply the movement to the enemy
        player.Move(moveDirection * Time.deltaTime);
    }
}
