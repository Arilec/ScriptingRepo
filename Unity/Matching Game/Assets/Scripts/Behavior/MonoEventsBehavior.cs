using System;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehavior : MonoBehaviour
{

   public UnityEvent startEvent, OnDisableEvent;

   public void Start()
   {
      startEvent.Invoke();
   }

   public void OnDisable()
   {
      OnDisableEvent.Invoke();
   }
}
