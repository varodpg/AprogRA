using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SonidoActDes : MonoBehaviour
{
    AudioSource audioSource;
    public Button sonido;
    public Text text;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        sonido.onClick.AddListener(TaskOnClick);
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
}
