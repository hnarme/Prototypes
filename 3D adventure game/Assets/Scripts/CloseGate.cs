using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGate : MonoBehaviour
{
    public Animator closeGate;
    public bool enteredBossRoom = false;

    // Update is called once per frame
    void Update()
    {
        closeGate.SetBool("enteredBossRoom", enteredBossRoom);
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            enteredBossRoom = true;
        }
        else
        {
            enteredBossRoom = false;
        }
    }
}
