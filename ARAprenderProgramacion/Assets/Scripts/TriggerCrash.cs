using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerCrash : MonoBehaviour
{ 
    public CambiarCanvas cc;
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Crash");
        cc.showCrashCanvas();
    }
}
