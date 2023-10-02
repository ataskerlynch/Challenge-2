﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spawnInterval = 1f;
    public bool spawnEnabled = true;

    void Start()
    {
        //StartCoroutine("SpawnTimer");
    }
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && spawnEnabled==true)
        {
            spawnEnabled = false;
            Instantiate(dogPrefab, dogPrefab.transform.position, dogPrefab.transform.rotation);
            StartCoroutine("SpawnTimer");
        }
        
    }

    public IEnumerator SpawnTimer()
    {
        yield return new WaitForSeconds(spawnInterval);
        spawnEnabled = true;
    }

}
