using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPortal : MonoBehaviour
{
    public GameObject portal;

    public GameObject Boss;

    // Update is called once per frame
    void Update()
    {
        if (!Boss.activeInHierarchy)
        {
            portal.SetActive(true);
        }
    }
}
