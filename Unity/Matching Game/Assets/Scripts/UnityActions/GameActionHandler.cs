using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GameAction gameActionOBJ;
    public UnityEvent onRaiseEvent;
    private void Start()
    {
        gameActionOBJ.raise += Raise;
    }

    private void Raise()
    {
        onRaiseEvent.Invoke();
    }
}
