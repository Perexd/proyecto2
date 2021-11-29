using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destrozasalirlimites : MonoBehaviour
{
    private float upperLim = 30f;
    private float lowerLim = -10f;

    // Update is called once per frame
    void Update()
    {
       //bala fallida
      if (transform.position.z > upperLim)
        {
            Destroy(gameObject);
        }
      //animal se va y detener juego
        if (transform.position.z < lowerLim)
        {
            Destroy(gameObject);
          
        }
    }
}
