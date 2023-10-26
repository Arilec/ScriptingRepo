using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{
    [SerializeField] private FloatData healthValue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //apply the health value to the player
            //ApplyHealth(other.gameObject);
            
            //destroy the power up in game
            Destroy(gameObject);
        }
    }
/*
    private void ApplyHealth(GameObject player)
    {
        //retrieve the player's health component
        HealthController healthController = player.GetComponent<HealthController>();
        
        //check if player has health controller
        if (healthController != null)
        {
            healthController.AddHealth(healthValue.Value);
        }
    }
    */
}
