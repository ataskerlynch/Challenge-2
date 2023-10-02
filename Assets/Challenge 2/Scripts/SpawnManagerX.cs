using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -2;
    private float spawnLimitXRight = 4;
    private float spawnPosY = 8;
    private float spawnPosZ = -2f;
    private float minDelay = 3;
    private float maxDelay = 5;
   
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        float startDelay = Random.Range(minDelay, maxDelay);
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int ballIndex = Random.Range(0, ballPrefabs.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, spawnPosZ);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }

}
