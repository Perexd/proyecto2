using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    private float horizontalInput;
    private float speed = 10f;
    private float xRange = 16f;

    public GameObject ProjectailPrefab;

    // Update is called once per frame
    void Update()
    {
        //movimiento del pesonaje
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y,transform.position.z);
        }  
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y,transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))

       Instantiate(ProjectailPrefab, transform.position, ProjectailPrefab.transform.rotation);   
    }
 
}
