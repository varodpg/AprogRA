using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SonidoActDes : MonoBehaviour
{
    public static SonidoActDes instance = null;
    bool actDes;
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
        actDes = PlayerPrefs.GetInt("Sound") == 1;
        if(actDes== false)
        {
            text.text = "Sonido activado";
            audioSource.mute = false;
        }
        else
        {
            text.text = "Sonido desactivado";
            audioSource.mute = true;
        }
       
    }

    void TaskOnClick()
    {
        audioSource.mute = !audioSource.mute;
        if (PlayerPrefs.GetInt("Sound")==0)
        {
            text.text = "Sonido desactivado";
            PlayerPrefs.SetInt("Sound", 1);
        }
        else
        {
            text.text = "Sonido activado";
            PlayerPrefs.SetInt("Sound", 0);
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
