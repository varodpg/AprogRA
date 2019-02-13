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
    public Vector3 posActual, posDestino, rotacionActual;
    Vector3 m_EulerAngleVelocity;
    private MovFluido mov;
    public bool mover = false;
    Vector3 pos;
    private int dir = 0;

   


    void Start()
    {
        botonEjecutar.onClick.AddListener(NewMethod);
        posActual = new Vector3(car.transform.position.x, car.transform.position.y, car.transform.position.z);

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
                        dir = 1;
                        break;
                    case 2: //derecha
                        dir = 2;
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

                        mover = true;
                        //posActual = posDestino;
                        
                        break;
                    case 3: //abajo
                        dir = 3;
                        posDestino = new Vector3(posActual.x , car.transform.position.y, car.transform.position.z - (1.3f * 0.3f));
                        
                      
                        break;
                    case 4: //izquierda
                        dir = 4;
                        posDestino = new Vector3(posActual.x , car.transform.position.y, car.transform.position.z +(1.3f * 0.3f));
        
                        
                        break;
                    default:
                        break; // podemos mostrar un mensaje por pantalla diciendo que no hay ningún movimiento.
                }
                //car.MovePosition(Vector3.MoveTowards(posActual, posDestino, 1));
               
                

            }
        }
        catch (System.Exception)
        {
            Debug.Log("No hay elementos en el array");
        }


    }

 

    private void FixedUpdate()
    {
       
        if (mover == true) {
            car.transform.position = car.transform.position + (new Vector3(0.002f,0,0));
            posActual = car.transform.position;
            if (posActual == posDestino)
            {
                mover = false;
            }
            
        }
    }

}
