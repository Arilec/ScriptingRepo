using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehavior : MonoBehaviour
{
    public bool _canRun;
    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalseEvent;
    public IntData counterNum;
    public float seconds = 3.0f;

    private WaitForSeconds wfsobj;

    private WaitForFixedUpdate wffuobj;

    public bool CanRun
    {
        get => _canRun;
        set => _canRun = value;
    }


    // Start is called before the first frame update
    void Start()
    {
        wfsobj = new WaitForSeconds(seconds);
        wffuobj = new WaitForFixedUpdate();
        startEvent.Invoke();
    }

    public void StartCounting()
    {
        StartCoroutine(Counting());
    }
    private IEnumerator Counting()
    {
       
        
        startCountEvent.Invoke();
        while (counterNum.value > 0)
        {
            repeatCountEvent.Invoke();
            counterNum.value--;
            yield return wfsobj;
        }
        endCountEvent.Invoke();
    }

    public void startRepeatUntilFalse()
    {
        StartCoroutine(repeatUntilFalse());
    }

    private IEnumerator repeatUntilFalse()
    {
        while (CanRun)
        {
            yield return wfsobj;
            repeatUntilFalseEvent.Invoke();
            
        }
    }
}
