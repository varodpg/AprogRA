using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class Ejecutar : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody car, star;
    public ArrayList direcciones;
    public Button botonEjecutar;
    public Vector3 posActual, posDestino;
    public Quaternion rotacionDestino, rotacionInicial;
    Vector3 m_EulerAngleVelocity;
    private MovFluido mov;
    public bool mover = false;
    private bool continuar = false;
    Vector3 pos;
    private int dir = 0;




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

    public Vector3 getEuler()
    {
        return m_EulerAngleVelocity;
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
        StartCoroutine(Wait(dirs));
    }
    

    private void Update()
    {
        if (mover == true)
        {
            if (dir == 2) //derecha
            {
                if  (posDestino.x - car.position.x >= 0.01f)
                {
                    if ((90.1f < car.transform.rotation.eulerAngles.y) & (89.9f > car.transform.rotation.eulerAngles.y))
                    {
                        car.transform.rotation = Quaternion.Slerp(car.transform.rotation, rotacionDestino, Time.deltaTime * 5.0f);
                    }
                    car.MovePosition(new Vector3(car.position.x + 0.01f, car.position.y, car.position.z));
                }
                

            }
            else if (dir == 3)//abajo
            {
                Debug.Log("Primer paso");
                if (car.position.z - posDestino.z >= 0.01)
                {
                    if ((180.1f < car.transform.rotation.eulerAngles.y) & (179.9f > car.transform.rotation.eulerAngles.y))
                    {
                        car.transform.rotation = Quaternion.Slerp(car.transform.rotation, rotacionDestino, Time.deltaTime * 5.0f);
                    }
                    Debug.Log("Cuarto paso");
                    car.MovePosition(new Vector3(car.position.x, car.position.y, car.position.z - 0.01f));
                }
            }
            else if (dir == 1) //arriba
            {
                if (car.position.z - posDestino.z <= 0.01)
                {
                    if ((0.1f < car.transform.rotation.eulerAngles.y) & (0.9f > car.transform.rotation.eulerAngles.y))
                    {
                        car.transform.rotation = Quaternion.Slerp(car.transform.rotation, rotacionDestino, Time.deltaTime * 5.0f);
                    }
                    car.MovePosition(new Vector3(car.position.x, car.position.y, car.position.z + 0.01f));
                }
            }
            else if (dir == 4)//izquierda
            {
                Debug.Log("Posicion resultante: " + (posDestino.x - car.position.x));
                if ((posDestino.x < car.position.x)) 
                {
                    //if (car.transform.rotation.y != rotacionDestino.y)
                    {
                        Debug.Log("Rotacion actual: " + car.rotation.y);
                        if ((270.1f < car.transform.rotation.eulerAngles.y) & (269.9f > car.transform.rotation.eulerAngles.y))
                        {
                            car.transform.rotation = Quaternion.Slerp(car.transform.rotation, rotacionDestino, Time.deltaTime * 5.0f);
                        }
                        Debug.Log("Segunda Rotacion actual: " + car.rotation.y);
                        Debug.Log("Supuesta Rotacion destino: " + rotacionDestino);

                    }
                    car.MovePosition(new Vector3(car.position.x - 0.01f, car.position.y, car.position.z));
                }


            }
            else
            {
                mover = false;
            }
            
        }
    }

    IEnumerator Wait(ArrayList direc)
    {
        posActual = new Vector3(car.transform.position.x, car.transform.position.y, car.transform.position.z);
        for (int i = 0; i < direc.Count; i++)
        {
            
            if (direc[i].Equals(1)) //arriba
            {
                posDestino = new Vector3(car.transform.position.x, car.transform.position.y, car.transform.position.z + (1.3f * 0.3f));
                rotacionDestino = Quaternion.Euler(car.rotation.x, 0, car.rotation.z);
                yield return new WaitForSeconds(1.5f);
                Debug.Log("Ejecutando la posicion: " + i + ":" + direc[i]);
                dir = 1;
                mover = true;
                yield return new WaitForSeconds(1.5f);
            }
            if (direc[i].Equals(2)) //derecha
            {

                posDestino = new Vector3(car.transform.position.x + (1.3f * 0.3f), car.transform.position.y, car.transform.position.z);
                rotacionDestino = Quaternion.Euler(car.rotation.x, 90, car.rotation.z);
                yield return new WaitForSeconds(1.5f);
                Debug.Log("Ejecutando la posicion: " + i + ":" + direc[i]);
                dir = 2;
                mover = true;
                
                
                yield return new WaitForSeconds(1.5f); 
                

            }
            if (direc[i].Equals(3)) //abajo
            {
                posDestino = new Vector3(car.transform.position.x , car.transform.position.y, car.transform.position.z - (1.3f * 0.3f));
                rotacionDestino = Quaternion.Euler(car.rotation.x, 180, car.rotation.z);
                yield return new WaitForSeconds(1.5f);
                Debug.Log("Ejecutando la posicion: " + i + ":" + direc[i]);
                dir = 3;
                mover = true;
                yield return new WaitForSeconds(1.5f);
            }
            if (direc[i].Equals(4)) //izquierda
            {
                posDestino = new Vector3(car.transform.position.x - (1.3f * 0.3f), car.transform.position.y, car.transform.position.z);
                rotacionDestino = Quaternion.Euler(car.rotation.x, 270, car.rotation.z);
                yield return new WaitForSeconds(1.5f);
                Debug.Log("Ejecutando la posicion: " + i + ":" + direc[i]);
                dir = 4;
                mover = true;


                yield return new WaitForSeconds(1.5f);
            }
            posActual = posDestino;
        }

    }




}
