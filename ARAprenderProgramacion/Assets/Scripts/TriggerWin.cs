using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerWin : MonoBehaviour
{
    public Button botonVolver, siguienteNivel;
    public CambiarCanvas cc;
    public Ejecutar e;
    private int level;

    private void Start()
    {
        botonVolver.onClick.AddListener(GoBack);
        siguienteNivel.onClick.AddListener(NextLevel);
        level = 1;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("WIIIIN");
        cc.changeWin();
        e.mover = false;
        e.choque = false;
        e.haGanado = true;
    }

    void GoBack()
    {
        cc.volverMenu();
    }
    void NextLevel()
    {
        cc.siguienteNivel(level);
    }

}
