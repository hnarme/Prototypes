using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroller : MonoBehaviour
{
    public Transform[] waypoint;
    public float speed;

    private int wayPointIndex;
    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        wayPointIndex = 0;
        transform.LookAt(waypoint[wayPointIndex].position);
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, waypoint[wayPointIndex].position);
        if (distance < 1f)
        {
            IncreaseIndex();
        }

        Patrol();
    }

    public void Patrol()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void IncreaseIndex()
    {
        wayPointIndex++;
        if (wayPointIndex >= waypoint.Length)
        {
            wayPointIndex = 0;
        }

        transform.LookAt(waypoint[wayPointIndex].position);
    }
}
