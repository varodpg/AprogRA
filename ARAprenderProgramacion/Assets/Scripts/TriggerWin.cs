using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerWin : MonoBehaviour
{
    public Button botonVolver;
    public CambiarCanvas cc;

    private void Start()
    {
        botonVolver.onClick.AddListener(GoBack);
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("WIIIIN");
        cc.changeWin();
    }

    void GoBack()
    {
        cc.volverMenu();
    }

}
