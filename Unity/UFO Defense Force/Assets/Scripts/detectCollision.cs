using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollision : MonoBehaviour
{

    public ScoreManager scoreManager; //reference to score manager

    public int scoreToGive;
    public float Damage; //only applies on player

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //find Score manager Component and reference scoreManager
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Enemy")) //Compares tags to see if the colliding object is a player
        {
            other.GetComponent<HealthController>().SubtractHealth(Damage);
        }
        else
        {
            scoreManager.IncreaseScore(scoreToGive); //Increase the Score
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

    }
}
