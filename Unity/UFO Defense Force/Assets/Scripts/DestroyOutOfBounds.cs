using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float upperBounds = 30.0f;

    public float lowerBounds = -10.0f;
    public GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > upperBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBounds)
        {
            if (CompareTag("Enemy"))
            {
                Debug.Log("Game Over");
                gameManager.isGameOver = true;
            }
            Destroy(gameObject);
            //Time.timeScale = 0;
        }
    }
}
