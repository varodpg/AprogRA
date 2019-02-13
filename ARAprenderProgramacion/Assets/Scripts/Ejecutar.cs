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
    public WaitSeconds wait;
    private Vector3 posActual, posDestino, rotacionActual;
    Vector3 m_EulerAngleVelocity;
    private MovFluido mov;
    private bool mover = false;
    Vector3 pos;


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

    public Vector3 getRotActual()
    {
        return rotacionActual;
    }

    public void setPosActual(Vector3 pos)
    {
        posActual = pos;
    }
    public void setPosDestino(Vector3 pos)
    {
        posDestino = pos;
    }

    public void setRotActual(Vector3 rot)
    {
        rotacionActual = rot;
    }

    public Vector3 getEuler()
    {
        return m_EulerAngleVelocity;
    }

#endregion

    //public void aniadirDireccion(int dir)
    //{
    //    if (direcciones == null)
    //    {
    //        direcciones = new ArrayList(5);
    //        direcciones.Add(dir); // se añade por el final
    //        Debug.Log("POSICION INICIAL: " + car.position.x);
    //        Debug.Log("Añadida primera direccion");
    //    }
    //    else
    //    {
    //        direcciones.Add(dir); // se añade por el final
    //        Debug.Log("un marcador ha añadido una direccion");
    //        for (int i = 0; i < direcciones.Count; i++)
    //        {
    //            Debug.Log(direcciones[i]);
    //        }

    //    }

    //}
    public void mostrarArray(ArrayList direcciones)
    {
        Debug.Log("Inicio del array");
        for (int  i = 0;  i < direcciones.Count;  i++)
        {
            Debug.Log(direcciones[i]);
        }
        Debug.Log("Fin del array");
    }
    public void ejecutarMovimiento(ArrayList dirs) //añadir al OnClick() del boton ejecutar
    {
        posActual = new Vector3(car.transform.position.x, car.transform.position.y, car.transform.position.z);
        mostrarArray(direcciones);
        // if dirs está vacío mostrar canvas (usa los marcadores)
        try
        {
            for (int i = 0; i < dirs.Count; i++)
            {
                
                switch (dirs[i])
                {
                    case 1: //arriba
                                                   
                            
                            posDestino = new Vector3(car.transform.position.x, car.transform.position.y, posActual.z + (1.3f * 0.3f));
                            m_EulerAngleVelocity = new Vector3(0, 100, 0);
                                //mov.Start();// FixedUpdate();
                                            //car.transform.Rotate(0, -90, 0);

                            
                            




                        break;
                    case 2: //derecha
                        posDestino = new Vector3(posActual.x + (1.3f * 0.3f), car.transform.position.y, car.transform.position.z);
                        m_EulerAngleVelocity = new Vector3(0, 100, 0);
                        Debug.Log("Angulo: "+car.transform.rotation.eulerAngles.y);
                        if (car.transform.rotation.eulerAngles.y > 90.1)
                        {
                            car.transform.Rotate(Vector3.up, -90);
                        }
                        if (car.transform.rotation.eulerAngles.y < 90)
                        {
                            car.transform.Rotate(Vector3.up, 90);
                        }
                        star.MovePosition(Vector3.MoveTowards(new Vector3(star.transform.position.x, star.transform.position.y, star.transform.position.z), new Vector3 (star.transform.position.x +0.5f, star.transform.position.y, star.transform.position.z), 1));

                        break;
                    case 3: //abajo
                        posDestino = new Vector3(posActual.x - (1.3f * 0.3f), car.transform.position.y, car.transform.position.z);
                        
                      
                        break;
                    case 4: //izquierda
                        posDestino = new Vector3(posActual.x - (1.3f * 0.3f), car.transform.position.y, car.transform.position.z);
        
                        
                        break;
                    default:
                        break; // podemos mostrar un mensaje por pantalla diciendo que no hay ningún movimiento.
                }
                //car.MovePosition(Vector3.MoveTowards(posActual, posDestino, 1));
                posActual = posDestino;
                mover = true;

            }
        }
        catch (System.Exception)
        {
            Debug.Log("No hay elementos en el array");
        }


    }

    private void FixedUpdate()
    {
        if (mover)
        {
            
            car.MovePosition(Vector3.MoveTowards(posActual, posDestino,Time.deltaTime * 0.001f));
            //pos = Vector3.Lerp(posActual, posDestino, 0.0000001f);
            star.MovePosition(Vector3.Lerp(posActual, posDestino, 0.0000001f)); ///NO FUNCIONAAAAA


        }
        mover = false;
    }

    //private void FixedUpdate()
    //{
    //    posActual = new Vector3(car.transform.position.x, car.transform.position.y, car.transform.position.z);
    //    Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.deltaTime);
    //    car.MoveRotation(car.rotation * deltaRotation);
    //    car.MovePosition(Vector3.MoveTowards(posActual, posDestino, 3)* Time.deltaTime);
    //}

}
