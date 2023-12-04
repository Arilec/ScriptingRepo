using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{
   public ID IDObj;
   public UnityEvent matchEvent, noMatchEvent, noMatchDelay;
   private IEnumerator OnTriggerEnter(Collider other)
   {
      var tempOBJ =  other.GetComponent<MatchBehavior>(); //14-16 check for null and cancel if null
      if (tempOBJ == null)
         yield break;
         
      var otherID = tempOBJ.IDObj;
      if (otherID == IDObj) //if match
      {
         matchEvent.Invoke();
      }
      else //no match
      {
         noMatchEvent.Invoke();
         yield return new WaitForSeconds(0.5f);
         noMatchDelay.Invoke();
      }
   }
}
