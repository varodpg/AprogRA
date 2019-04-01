using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class Ejecutar : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody car, star, cocheAuto;
    public ArrayList direcciones;
    public Button botonEjecutar;
    public Vector3 posActual, posDestino, posDestinoAuto;
    public Quaternion rotacionDestino, rotacionInicial;
    public bool mover = false;
    private bool continuar = false;
    public bool choque = false;
    Vector3 pos;
    private int dir = 0;
    public CambiarCanvas cc;
    public bool haGanado = false;
    public int maxMovimientos;
    private bool stopSignal = false;
    private int nMovimientos = 0;
  




    void Start()
    {
        botonEjecutar.onClick.AddListener(NewMethod);
    }

    private void NewMethod()
    {
        ejecutarMovimiento(direcciones);
    }

    #region GETTERS Y SETTERS

    public Vector3 getPosActual()
    {
        return posActual;
    }
    public Vector3 getPosDestino()
    {
        return posDestino;
    }

    public void setPosActual(Vector3 pos)
    {
        posActual = pos;
    }
    public void setPosDestino(Vector3 pos)
    {
        posDestino = pos;
    }

    #endregion


    public void mostrarArray(ArrayList direcciones)
    {
        Debug.Log("Inicio del array");
        for (int i = 0; i < direcciones.Count; i++)
        {
            Debug.Log(direcciones[i]);
        }
        Debug.Log("Fin del array");
    }

    public void ejecutarMovimiento(ArrayList dirs) // (1.3f * 0.3f)
    {
        
        if ((dirs == null) & (cc.inMenu == false))
        {
            StartCoroutine(ShowM());
        }
        else
        {
            if (cc.inMenu == false)
            {
                StartCoroutine(Wait(dirs));
            }
        }
    }
    
    IEnumerator ShowM() //Mostrar que no hay direcciones
    {
        cc.canvasNoDir.GetComponent<Canvas>().enabled = true;
        yield return new WaitForSeconds(3);
        cc.canvasNoDir.GetComponent<Canvas>().enabled = false;
    }

    private void Update() //Movimiento del coche
    {
        if (choque == true)
        {

            if (mover == true)
            {
                if (dir == 2) //derecha
                {
                    if (car.transform.rotation.y != rotacionDestino.y)
                    {
                        car.MoveRotation(rotacionDestino);
                    }
                    if (posDestino.x - car.position.x >= 0.01f)
                    {
                        car.MovePosition(new Vector3(car.position.x + 0.015f, car.position.y, car.position.z));
                    }


                }
                else if (dir == 3)// Abajo
                {
                    if (car.transform.rotation.y != rotacionDestino.y) // Rotacion
                    {
                        car.MoveRotation(rotacionDestino);
                    }
                    if (car.position.z - posDestino.z >= 0.01) // Movimiento
                    {
                        car.MovePosition(new Vector3(car.position.x, car.position.y, car.position.z - 0.015f));
                    }
                }
                else if (dir == 1) //arriba
                {
                    if (car.transform.rotation.y != rotacionDestino.y)
                    {
                        car.MoveRotation(rotacionDestino);
                    }
                    if (car.position.z - posDestino.z <= 0.01f)
                    {
                        car.MovePosition(new Vector3(car.position.x, car.position.y, car.position.z + 0.015f));
                    }
                }
                else if (dir == 4)//izquierda
                {
                    if (car.transform.rotation.y != rotacionDestino.y)
                    {
                        car.MoveRotation(rotacionDestino);
                    }
                    if ((car.position.x - posDestino.x) >= 0.01f)
                    {
                        car.MovePosition(new Vector3(car.position.x - 0.015f, car.position.y, car.position.z));
                    }
                }
                else if (dir == 5) //esperar
                {
                    if ((posDestinoAuto.x > cocheAuto.position.x))
                    {
                        cocheAuto.MovePosition(new Vector3(cocheAuto.position.x + 0.015f, cocheAuto.position.y, cocheAuto.position.z));
                    }

                }
                else
                {
                    mover = false;
                }

            }
        }
    }





    IEnumerator Wait(ArrayList direc)
    {
        posActual = new Vector3(car.transform.position.x, car.transform.position.y, car.transform.position.z);

        for (int i = 0; i < direc.Count; i++) //Lectura del array
        {

            if (direc[i].Equals(1)) //arriba (1.3f * 0.3f)
            {
                posDestino = new Vector3(car.transform.position.x, car.transform.position.y, car.transform.position.z + 0.45f);
                rotacionDestino = Quaternion.Euler(car.rotation.x, 0, car.rotation.z);
                yield return new WaitForSeconds(1.5f);
                Debug.Log("Ejecutando la posicion: " + i + ":" + direc[i]);
                dir = 1;
                mover = true;
                nMovimientos += 1;
                yield return new WaitForSeconds(1.5f);
                if (direc.Count == 1)
                    break;
            }
            if (direc[i].Equals(2)) //derecha
            {

                posDestino = new Vector3(car.transform.position.x + 0.45f, car.transform.position.y, car.transform.position.z);
                rotacionDestino = Quaternion.Euler(car.rotation.x, 90, car.rotation.z);
                yield return new WaitForSeconds(1.5f);
                Debug.Log("Ejecutando la posicion: " + i + ":" + direc[i]);
                dir = 2;
                nMovimientos += 1;
                mover = true;


                yield return new WaitForSeconds(1.5f);
                if (direc.Count == 1)
                    break;

            }
            if (direc[i].Equals(3)) //abajo
            {
                posDestino = new Vector3(car.transform.position.x, car.transform.position.y, car.transform.position.z - 0.45f);
                rotacionDestino = Quaternion.Euler(car.rotation.x, 180, car.rotation.z);
                yield return new WaitForSeconds(1.5f);
                Debug.Log("Ejecutando la posicion: " + i + ":" + direc[i]);
                dir = 3;
                nMovimientos += 1;
                mover = true;
                yield return new WaitForSeconds(1.5f);
                if (direc.Count == 1)
                    break;
            }
            if (direc[i].Equals(4)) //izquierda
            {
                posDestino = new Vector3(car.transform.position.x - 0.45f, car.transform.position.y, car.transform.position.z);
                rotacionDestino = Quaternion.Euler(car.rotation.x, 270, car.rotation.z);
                yield return new WaitForSeconds(1.5f);
                Debug.Log("Ejecutando la posicion: " + i + ":" + direc[i]);
                dir = 4;
                mover = true;
                yield return new WaitForSeconds(1.5f);
                if (direc.Count == 1)
                    break;
            }

            if (direc[i].Equals(5))
            {
                posDestinoAuto = new Vector3(cocheAuto.transform.position.x + (3 * 0.45f), cocheAuto.transform.position.y, cocheAuto.transform.position.z);
                yield return new WaitForSeconds(1.5f);
                dir = 5;
                nMovimientos += 1;
                mover = true;
                yield return new WaitForSeconds(1.5f);
                if (direc.Count == 1)
                    break;

            }
            // ESTO SOLO PARA EL STOP. (lvl 4)
            if ((cc.nivelActual == 8) & (direcciones[0].Equals(1)) & (direcciones[1].Equals(1)) & (i == 1)) //Si es el nivel 8 y ha marcado arriba arriba en la 1 y 2 posicion, eso es que no ha esperado en el cruce
            {
                mover = false;
                stopSignal = true;
                cc.stopDefeat();
                break;
            }
        }
        mover = false;
        // Comprobar si ha llegado o no al destino.
        if ((direc.Count == 1) & (haGanado == false) & (choque == true) & (stopSignal == false))
        {
            cc.changeDefeat();
        }

        if ((haGanado == false) & (choque == true) & (stopSignal == false))// Si no ha llegado al destino y no se ha chocado / salido de la carretera.
        {
            cc.changeDefeat();
        }


    }
}
