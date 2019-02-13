using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovFluido : MonoBehaviour
{
    // Start is called before the first frame update
    public Ejecutar ejecutar;
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        //ejecutar.setPosActual( new Vector3(ejecutar.car.transform.position.x, ejecutar.car.transform.position.y, ejecutar.car.transform.position.z));
        //Quaternion deltaRotation = Quaternion.Euler(ejecutar.getEuler() * Time.deltaTime);
        //ejecutar.car.MoveRotation(ejecutar.car.rotation * deltaRotation);
        ejecutar.car.transform.Rotate(Vector3.up, -90);
        //ejecutar.car.MovePosition(Vector3.MoveTowards(ejecutar.getPosActual(), ejecutar.getPosDestino(), 3) * Time.deltaTime);
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
