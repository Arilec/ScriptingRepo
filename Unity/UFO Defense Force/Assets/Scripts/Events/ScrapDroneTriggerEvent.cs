using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class ScrapDroneTriggerEvent : MonoBehaviour
{
    public UnityEvent destroyEvent;

    private Collider colliderOBJ;

    private void Start()
    {
        colliderOBJ = GetComponent<Collider>();
        colliderOBJ.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        transform.LookAt(other.gameObject.transform);
    }

    private void OnDestroy()
    {
        destroyEvent.Invoke();
    }

    
        
    
}

