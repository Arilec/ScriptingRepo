using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawnManager : MonoBehaviour
{

    public GameObject[] UFOPrefabs; //array to store UFO ships
    private float spawnRangeX = 20f;
    private float spawnRangeY = 20f;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;
    
    int UFOIndex;

    void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //spawn random UFO function
    void SpawnRandomUFO()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0f, spawnRangeY);
            
        UFOIndex = Random.Range(0, UFOPrefabs.Length); //picks random ufo from array
        //spawns from UFO array at a random location on X axis
        Instantiate(UFOPrefabs[UFOIndex], spawnPos, UFOPrefabs[UFOIndex].transform.rotation);
    }
}
