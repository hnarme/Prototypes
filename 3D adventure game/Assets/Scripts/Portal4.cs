using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal4 : MonoBehaviour
{
    public PortalSceneLoader portalScene;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            portalScene.PortalScene4();
        }
    }
}
