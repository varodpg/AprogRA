﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugar : MonoBehaviour
{
    // Start is called before the first frame update
    public void playGame(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
