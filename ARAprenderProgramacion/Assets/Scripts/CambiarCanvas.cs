using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CambiarCanvas : MonoBehaviour
{
    public Canvas canvasFlechas, canvasWin, canvasChoque, canvasNoDir, canvasDerrota;
    public Canvas canvasGame;
    public Rigidbody car;
    private Vector3 posicionFinal;
    public int nivelActual;
    private int contador = 0;
    public bool showText = false, noDirCondicion = false;
    private float currentTime = 0.0f, executedTime = 0.0f, timeToWait = 5.0f;

    void Start()
    {
        canvasFlechas.GetComponent<Canvas>().enabled = false;
        canvasGame.GetComponent<Canvas>().enabled = true;
        canvasWin.GetComponent<Canvas>().enabled = false;
        canvasChoque.GetComponent<Canvas>().enabled = false;
        canvasNoDir.GetComponent<Canvas>().enabled = false;
        canvasDerrota.GetComponent<Canvas>().enabled = false;

    }

    public void changeWin()
    {
        canvasGame.GetComponent<Canvas>().enabled = false;
        canvasFlechas.GetComponent<Canvas>().enabled = false;
        canvasWin.GetComponent<Canvas>().enabled = true;
        canvasChoque.GetComponent<Canvas>().enabled = false;
        GameObject.Find("WinIcon").SetActive(false);
        canvasNoDir.GetComponent<Canvas>().enabled = false;
        canvasDerrota.GetComponent<Canvas>().enabled = false;
    }
    public void showCrashCanvas()
    {
        canvasGame.GetComponent<Canvas>().enabled = false;
        canvasFlechas.GetComponent<Canvas>().enabled = false;
        canvasWin.GetComponent<Canvas>().enabled = false;
        canvasChoque.GetComponent<Canvas>().enabled = true;
        canvasNoDir.GetComponent<Canvas>().enabled = false;
        canvasDerrota.GetComponent<Canvas>().enabled = false;
    }
    public void volverMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void repetirNivel()
    {
        SceneManager.LoadScene("Level"+ nivelActual);
    }
    public void siguienteNivel()
    {
        SceneManager.LoadScene("Level" + (nivelActual + 1));
    }
    public void mostrarFlechas(string dir)
    {
        contador++;
        canvasFlechas.GetComponent<Canvas>().enabled = true;
        switch (contador)
        {
            case 1: // movimiento numero 1
                if (dir == "right") //Si queremos mostrar DCHA
                {
                    GameObject.Find("Right").transform.localScale = new Vector3(1, 1, 1);
                    GameObject.Find("Left").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Right2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Right3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Right4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down4").transform.localScale = new Vector3(0, 0, 0);


                }
                else if (dir == "up")
                {
                    GameObject.Find("Right").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up").transform.localScale = new Vector3(1, 1, 1);
                    GameObject.Find("Down").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Right2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Right3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Right4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down4").transform.localScale = new Vector3(0, 0, 0);
                }

                else if (dir == "down")
                {
                    GameObject.Find("Right").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down").transform.localScale = new Vector3(1, 1, 1);
                    GameObject.Find("Right2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Right3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Right4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down4").transform.localScale = new Vector3(0, 0, 0);
                }

                else if (dir == "left")
                {
                    GameObject.Find("Right").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left").transform.localScale = new Vector3(1, 1, 1);
                    GameObject.Find("Up").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Right2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Right3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Right4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down4").transform.localScale = new Vector3(0, 0, 0);
                }
                break;
            case 2: // segundo movimiento
                if (dir == "right") //Si queremos mostrar DCHA
                {
                    GameObject.Find("Right2").transform.localScale = new Vector3(1, 1, 1);
                    GameObject.Find("Left2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Right3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Right4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down4").transform.localScale = new Vector3(0, 0, 0);
                }
                else if (dir == "up")
                {
                    GameObject.Find("Right2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up2").transform.localScale = new Vector3(1, 1, 1);
                    GameObject.Find("Down2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Right3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Right4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down4").transform.localScale = new Vector3(0, 0, 0);
                }

                else if (dir == "down")
                {
                    GameObject.Find("Right2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down2").transform.localScale = new Vector3(1, 1, 1);
                    GameObject.Find("Right3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Right4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down4").transform.localScale = new Vector3(0, 0, 0);
                }

                else if (dir == "left")
                {
                    GameObject.Find("Right2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left2").transform.localScale = new Vector3(1, 1, 1);
                    GameObject.Find("Up2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down2").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Right3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Right4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down4").transform.localScale = new Vector3(0, 0, 0);
                }
                break;
            case 3: // segundo movimiento
                if (dir == "right") //Si queremos mostrar DCHA
                {
                    GameObject.Find("Right3").transform.localScale = new Vector3(1, 1, 1);
                    GameObject.Find("Left3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Right4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down4").transform.localScale = new Vector3(0, 0, 0);
                }
                else if (dir == "up")
                {
                    GameObject.Find("Right3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up3").transform.localScale = new Vector3(1, 1, 1);
                    GameObject.Find("Down3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Right4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down4").transform.localScale = new Vector3(0, 0, 0);
                }

                else if (dir == "down")
                {
                    GameObject.Find("Right3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down3").transform.localScale = new Vector3(1, 1, 1);
                    GameObject.Find("Right4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down4").transform.localScale = new Vector3(0, 0, 0);
                }

                else if (dir == "left")
                {
                    GameObject.Find("Right3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left3").transform.localScale = new Vector3(1, 1, 1);
                    GameObject.Find("Up3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down3").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Right4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down4").transform.localScale = new Vector3(0, 0, 0);
                }
                break;
            case 4: // segundo movimiento
                if (dir == "right") //Si queremos mostrar DCHA
                {
                    GameObject.Find("Right4").transform.localScale = new Vector3(1, 1, 1);
                    GameObject.Find("Left4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down4").transform.localScale = new Vector3(0, 0, 0);
                }
                else if (dir == "up")
                {
                    GameObject.Find("Right4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up4").transform.localScale = new Vector3(1, 1, 1);
                    GameObject.Find("Down4").transform.localScale = new Vector3(0, 0, 0);
                }

                else if (dir == "down")
                {
                    GameObject.Find("Right4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Up4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down4").transform.localScale = new Vector3(1, 1, 1);
                }

                else if (dir == "left")
                {
                    GameObject.Find("Right4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Left4").transform.localScale = new Vector3(1, 1, 1);
                    GameObject.Find("Up4").transform.localScale = new Vector3(0, 0, 0);
                    GameObject.Find("Down4").transform.localScale = new Vector3(0, 0, 0);
                }
                break;
            default:
                break;
        }
        

    }

    public void moveStar(Rigidbody star)
    {
        star.transform.RotateAround(star.transform.position, new Vector3(0,1,0), Time.deltaTime * 90f);
    }

    public void changeDefeat()
    {
        canvasGame.GetComponent<Canvas>().enabled = false;
        canvasFlechas.GetComponent<Canvas>().enabled = false;
        canvasWin.GetComponent<Canvas>().enabled = false;
        canvasChoque.GetComponent<Canvas>().enabled = false;
        GameObject.Find("WinIcon").SetActive(false);
        canvasNoDir.GetComponent<Canvas>().enabled = false;
        canvasDerrota.GetComponent<Canvas>().enabled = true;
    }


    
            
    
}
