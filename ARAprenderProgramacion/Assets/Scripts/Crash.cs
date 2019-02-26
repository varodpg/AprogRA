using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crash : MonoBehaviour
{
    public Button repetirNivel, volverMenu;
    public CambiarCanvas cc;
    // Start is called before the first frame update
    void Start()
    {
        repetirNivel.onClick.AddListener(repetir);
        volverMenu.onClick.AddListener(menu);
    }

    // Update is called once per frame
    void repetir()
    {
        cc.repetirNivel(1);
    }
    void menu()
    {
        cc.volverMenu();
    }
}
