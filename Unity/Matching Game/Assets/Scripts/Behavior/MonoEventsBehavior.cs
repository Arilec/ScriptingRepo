using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehavior : MonoBehaviour
{

   public UnityEvent OnDisableEvent;
   public void OnDisable()
   {
      OnDisableEvent.Invoke();
   }
}
