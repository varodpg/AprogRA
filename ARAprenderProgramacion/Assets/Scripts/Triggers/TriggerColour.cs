using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerColour : MonoBehaviour
{
    public CambiarCanvas cc;
    public Ejecutar e;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Crash");
        e.mover = false;
        e.choque = false;
        cc.wrongColour();
    }
}
