using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Float Data",menuName = "Float Data")]

public class FloatData : ScriptableObject
{
    public float value;
    
    public void SetValue(float num)
    {
        value = num;
    }

    public void updateValue(float num)
    {
        value += num;
    }
}
