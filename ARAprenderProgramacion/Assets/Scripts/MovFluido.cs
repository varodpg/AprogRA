using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovFluido : MonoBehaviour
{
    // Start is called before the first frame update
    public Ejecutar ejecutar;
    public Rigidbody coche;
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void FixedUpdate()
    {

        //ejecutar.car.MovePosition(Vector3.MoveTowards(ejecutar.posActual, ejecutar.posDestino, 1));
        //ejecutar.arrancar(ejecutar.car);
        
        
        
    }

    public void turnLeft()
    {
        //ejecutar.car.transform.Rotate(Vector3.up, -90);
    }

    public void turnRight()
    {
        //ejecutar.car.transform.Rotate(Vector3.up, 90);
    }
}
