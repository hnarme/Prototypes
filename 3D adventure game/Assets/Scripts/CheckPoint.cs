using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public HealthManager healthManager;

    public Renderer theRend;

    public Material cpoff;
    public Material cpon;

    // Start is called before the first frame update
    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }

    public void CheckpointOn()
    {
        CheckPoint[] cps = FindObjectsOfType<CheckPoint>();
        foreach (CheckPoint cp in cps)
        {
            cp.CheckpointOff();
        }

        theRend.material = cpon;
    }

    public void CheckpointOff()
    {
        theRend.material = cpoff;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            healthManager.SetSpawnPoint(transform.position);
            CheckpointOn();
        }
    }
}
