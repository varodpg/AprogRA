using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovStar : MonoBehaviour
{
    public Rigidbody star;
    public CambiarCanvas cc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cc.moveStar(star);
    }
}
