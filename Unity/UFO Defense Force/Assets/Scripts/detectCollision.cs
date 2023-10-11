using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //we will see later what happens
        }
        else
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

    }
}
