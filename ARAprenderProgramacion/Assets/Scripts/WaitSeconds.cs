using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitSeconds : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        print(Time.time);
        yield return new WaitForSeconds(10);
        print(Time.time);
    }

}
