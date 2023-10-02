using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        // Move Game object forward at defined speed
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
