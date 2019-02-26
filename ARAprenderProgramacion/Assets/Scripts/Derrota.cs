using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Derrota : MonoBehaviour
{
    public Button botonVolver, botonReintentar;
    public CambiarCanvas cc;

    // Start is called before the first frame update
    void Start()
    {
        botonVolver.onClick.AddListener(GoBack);
        botonReintentar.onClick.AddListener(Reintentar);
    }

    // Update is called once per frame
    void GoBack()
    {
        cc.volverMenu();

    }
    void Reintentar()
    {
        cc.repetirNivel(1);
    }
}
