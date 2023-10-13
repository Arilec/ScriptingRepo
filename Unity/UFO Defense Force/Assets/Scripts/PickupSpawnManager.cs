using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawnManager : MonoBehaviour
{

    public GameObject PickupPrefab; //array to store UFO ships
    private float spawnRangeX = 20f;
    private float spawnRangeY = 20f;
    private float startDelay = 2f;
    private float spawnInterval = 60f;
    
    

    void Start()
    {
        InvokeRepeating("SpawnPickup", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //spawn random UFO function
    void SpawnPickup()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1f, spawnRangeY);
            
        
        //spawns from UFO array at a random location on X axis
        Instantiate(PickupPrefab, spawnPos, PickupPrefab.transform.rotation);
    }
}

