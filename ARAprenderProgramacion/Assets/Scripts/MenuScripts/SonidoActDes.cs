using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SonidoActDes : MonoBehaviour
{
    AudioSource audioSource;
    public Button sonido, reinciarNiveles, confirmar, cancelar;
    public Text text;
    public MainMenuScript mainMenu;
    public CambiarEscena ce;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        sonido.onClick.AddListener(TaskOnClick);
        confirmar.onClick.AddListener(reinicio);
        reinciarNiveles.onClick.AddListener(showConfirm);
        cancelar.onClick.AddListener(Cancelar);
    }

    void TaskOnClick()
    {
        audioSource.mute = !audioSource.mute;
        if (audioSource.mute)
        {
            //text.color = new Color(0f, 77f, 100f, 16f);
            text.text = "Sonido desactivado";
        }
        else
        {
            text.text = "Sonido activado";
        }
        
    }
    void reinicio()
    {
        mainMenu.resetPlayerPrefs();
        ce.closeConfirm();
    }
    void showConfirm()
    {
        ce.showConfirm();
    }
    void Cancelar()
    {
        ce.closeConfirm();
    }
}
