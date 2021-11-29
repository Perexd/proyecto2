using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour
{
private void OnTriggerEnter(Collider otherCollider)
    {
        // Destruyo el proyectil
        Destroy(gameObject);

        // Destruyo el animal contra el que colisiona
        Destroy(otherCollider.gameObject);
    }
}
