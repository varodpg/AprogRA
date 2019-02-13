using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CambiarCanvas : MonoBehaviour
{
    public Canvas canvasFlechas, canvasWin, canvasChoque;
    public Canvas canvasGame;
    public Rigidbody car;
    private Vector3 posicionFinal;
    private int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        canvasFlechas.GetComponent<Canvas>().enabled = false;
        canvasGame.GetComponent<Canvas>().enabled = true;
        canvasWin.GetComponent<Canvas>().enabled = false;
        canvasChoque.GetComponent<Canvas>().enabled = false;
        //foreach (Canvas i in canvasFlechas.gameObject.GetComponentsInChildren<Canvas>())
        //{
        //    i.enabled = false;
        //}
    }

    // Update is called once per frame
    public void changeWin()
    {
        canvasGame.GetComponent<Canvas>().enabled = false;
        canvasFlechas.GetComponent<Canvas>().enabled = false;
        canvasWin.GetComponent<Canvas>().enabled = true;
        canvasChoque.GetComponent<Canvas>().enabled = false;
    }
    public void showCrashCanvas()
    {
        canvasGame.GetComponent<Canvas>().enabled = false;
        canvasFlechas.GetComponent<Canvas>().enabled = false;
        canvasWin.GetComponent<Canvas>().enabled = false;
        canvasChoque.GetComponent<Canvas>().enabled = true;
    }
    public void volverMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void repetirNivel()
    {
        SceneManager.LoadScene("Level1");
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

    public void errorEjec()
    {
        //mostramos un canvas de error al no haber direcciones agragadas
    }

    
}
