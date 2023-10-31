using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class TriggerEventsBehavior : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private Collider colliderOBJ;

    private void Start()
    {
        colliderOBJ = GetComponent<Collider>();
        colliderOBJ.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}