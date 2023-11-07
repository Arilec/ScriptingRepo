using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawnManager : MonoBehaviour
{

    public GameObject[] PickupPrefab; //array to store UFO ships
    private float spawnRangeX = 20f;
    private float spawnRangeY = 20f;
    private float startDelay = 10f;
    private float spawnInterval = 10f;

    int pickupIndex;

    void Start()
    {
        InvokeRepeating("SpawnPickup", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //spawn random UFO function
    public void SpawnPickup()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1f, spawnRangeY);
            
        pickupIndex = Random.Range(0, PickupPrefab.Length);
        //spawns from UFO array at a random location on X axis
        Instantiate(PickupPrefab[pickupIndex], spawnPos, PickupPrefab[pickupIndex].transform.rotation);
    }
}

