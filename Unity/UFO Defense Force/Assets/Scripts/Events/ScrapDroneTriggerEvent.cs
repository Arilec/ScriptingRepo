using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class ScrapDroneTriggerEvent : MonoBehaviour
{
    public UnityEvent triggerEnterEvent, triggerExitEvent;

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

    private void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }
}

