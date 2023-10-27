using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPowerUp : MonoBehaviour
{
    [SerializeField] private IntData AmmoValue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //apply the health value to the player
            //AddAmmo(other.gameObject);
            
            //destroy the power up in game
            Destroy(gameObject);
        }
    }

    private void AddAmmo(GameObject player)
    {/*
        //retrieve the player's health component
       AmmoController ammoController = player.GetComponent<AmmoController>();
        
        //check if player has health controller
        if (ammoController != null)
        {
            ammoController.Reload(AmmoValue.Value);
        }
    */}

}
