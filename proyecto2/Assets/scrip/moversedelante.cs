using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moversedelante : MonoBehaviour
{
    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        //movimiento hacia delante
        transform.Translate(Vector3.forward * speed * Time.deltaTime); 
    }
}