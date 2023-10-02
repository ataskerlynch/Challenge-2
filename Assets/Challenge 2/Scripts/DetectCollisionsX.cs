using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        //  When a collision occurs destroy the game current object only 
        Destroy(gameObject);
    }
}
