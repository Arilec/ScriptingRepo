using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollision : MonoBehaviour
{

    public ScoreManager scoreManager; //reference to score manager

    public int scoreToGive;
    public float Damage; //only applies on player
   
    public AudioSource audioSource;

    public GameObject Explosion;
    
    public moveForward Move;
     

    void Start()
    {
        
        Move = GetComponent<moveForward>();//get movement controller
        audioSource = GameObject.Find("EnemyAudio").GetComponent<AudioSource>(); //finds audiosource for enemies
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //find Score manager Component and reference scoreManager
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player")) //Compares tags to see if the colliding object is a player
        {
            other.GetComponent<HealthController>().SubtractHealth(Damage);
        }
        else if (!other.gameObject.CompareTag("Enemy") && !other.gameObject.CompareTag("PickUp"))
        {
            scoreManager.IncreaseScore(scoreToGive); //Increase the Score
            Instantiate(Explosion, transform.position, Explosion.transform.rotation);
            audioSource.Play();
            Move.speed = 0f;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

    }
}
