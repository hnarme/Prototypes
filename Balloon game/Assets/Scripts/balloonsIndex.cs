using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonsIndex : MonoBehaviour
{
    private SpikeChecker spike;
    public int balloonTemp;
    public int balloonsRecord;
    public int balloonsStored;

    void Awake()
    {
        if (this.gameObject != null)
        {
            Destroy(this.gameObject);
            return;
        }
        // end of new code

        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public int Incrementballoon()
    {
        return balloonTemp++;
    }

    public int Updaterecordballoon()
    {
        if (balloonsRecord == 0)
        {
            balloonsRecord = balloonsStored;
        }
        else if (balloonsRecord < balloonsStored)
        {
            balloonsRecord = balloonsStored;
        }

        return balloonsRecord;
    }

    public int Resetballooncount()
    { 
        return balloonTemp = 0;
    }
}
