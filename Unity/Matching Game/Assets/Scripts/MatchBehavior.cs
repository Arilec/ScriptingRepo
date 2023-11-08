using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{
   public ID IDObj;
   public UnityEvent matchEvent, noMatchEvent;
   private void OnTriggerEnter(Collider other)
   {
      var tempOBJ =  other.GetComponent<IDContainerBehavior>();
      if (tempOBJ == null)
         return;
         
      var otherID = tempOBJ.IDObj;
      if (otherID == IDObj)
      {
         matchEvent.Invoke();
      }
      else
      {
         noMatchEvent.Invoke();
      }
   }
}
